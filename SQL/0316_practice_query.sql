DROP TABLE DEPT_COPY CASCADE CONSTRAINTS;
CREATE TABLE DEPT_COPY AS SELECT * FROM DEPARTMENT WHERE 0=1;
DROP TABLE EMP_COPY;
CREATE TABLE EMP_COPY AS SELECT * FROM EMPLOYEE WHERE 0=1;
DROP TABLE SALG_COPY;
CREATE TABLE SALG_COPY AS SELECT * FROM SALGRADE WHERE 0=1;

--INSERT INTO DEPT_COPY VALUES (10, 'ACCOUNTING', 'NEW YORK');
--INSERT INTO DEPT_COPY (DNO, LOC, DNAME) VALUES (20, 'DALLAS', 'RESEARCH');

INSERT INTO EMP_COPY VALUES (7369, 'SMITH', 'CLERK', 7902, TO_DATE('17-12-1980', 'dd-mm-yyyy'), 800, NULL, 20);
INSERT INTO DEPT_COPY SELECT * FROM DEPARTMENT;
INSERT INTO EMP_COPY SELECT * FROM EMPLOYEE;

DROP SEQUENCE SEQ;
CREATE SEQUENCE SEQ START WITH 1 INCREMENT BY 1 NOMAXVALUE NOMINVALUE;
DROP TABLE SEQ_TEST;
CREATE TABLE SEQ_TEST (ID NUMBER PRIMARY KEY, TITLE VARCHAR2(20));

INSERT INTO SEQ_TEST VALUES (SEQ.NEXTVAL, '타이틀1');
INSERT INTO SEQ_TEST VALUES (SEQ.NEXTVAL, '타이틀2');

SELECT * FROM USER_SEQUENCES;

UPDATE DEPT_COPY SET DNAME = 'PROGRAMING' WHERE DNO = 10;
UPDATE DEPT_COPY SET DNAME = 'HR';
UPDATE DEPT_COPY SET DNAME = 'PROGRAMING', LOC='SEOUL' WHERE DNO = 10;
UPDATE DEPT_COPY SET LOC=(SELECT LOC FROM DEPT_COPY WHERE DNO = 20) WHERE DNO = 10;

DELETE DEPT_COPY WHERE DNO = 10;
DELETE EMP_COPY WHERE DNO=(SELECT DNO FROM DEPARTMENT WHERE DNAME='SALES');

--숫자 데이터 검색
SELECT * FROM EMPLOYEE WHERE DNO = 10;
--문자 데이터 검색
SELECT * FROM EMPLOYEE WHERE ENAME='SCOTT';
--날짜 데이터 검색
SELECT * FROM EMPLOYEE WHERE HIREDATE <= '1981/01/01';
--논리 연산자 검색
SELECT * FROM EMPLOYEE WHERE DNO=10 AND JOB='MANAGER';
SELECT * FROM EMPLOYEE WHERE DNO=10 OR JOB='MANAGER';
SELECT * FROM EMPLOYEE WHERE NOT DNO=10;
--1000과 1500 사이값 검색
SELECT * FROM EMPLOYEE WHERE SALARY BETWEEN 1000 AND 1500;
--300, 500, 1400값 검색
SELECT * FROM EMPLOYEE WHERE COMMISSION IN(300, 500, 1400);
--F로 시작하는 이름을 가진 사원 검색
SELECT * FROM EMPLOYEE WHERE ENAME LIKE 'F%';
--_는 한 문자에 대한 WILDCARD역할, '_A'는 A글자 앞에 1글자만 아무것이나 올 수 있음
SELECT * FROM EMPLOYEE WHERE ENAME LIKE '_A%';
--NULL값 검색
SELECT * FROM EMPLOYEE WHERE COMMISSION IS NULL;
SELECT * FROM EMPLOYEE WHERE COMMISSION IS NOT NULL;
-- 오름차순, 내림차수 검색(DEFAULT는 오름차순, ASC생략 가능)
SELECT * FROM EMPLOYEE ORDER BY SALARY;
SELECT * FROM EMPLOYEE ORDER BY SALARY DESC;
SELECT * FROM EMPLOYEE ORDER BY SALARY DESC, ENAME ASC;
--그룹 함수
SELECT SUM(SALARY) AS "급여 총액", AVG(SALARY) AS "급여 평균", MAX(SALARY) AS "최대 급여", MIN(SALARY) AS "최소 급여" FROM EMPLOYEE;
--테이블 행 갯수
SELECT COUNT(*) AS "사원의 수" FROM EMPLOYEE;
--중복되지 않는 JOB갯수
SELECT COUNT(DISTINCT JOB) AS "직업 종류 갯수" FROM EMPLOYEE;
--특정 컬럼을 기준으로 그룹별로 나눔
SELECT DNO AS "부서 번호", AVG(SALARY) AS "급여 평균" FROM EMPLOYEE GROUP BY DNO;
SELECT JOB AS "직업", AVG(SALARY) AS "급여 평균" FROM EMPLOYEE GROUP BY JOB;
--다중 컬럼을 이용한 그룹별 검색
SELECT DNO, JOB, COUNT(*), SUM(SALARY) FROM EMPLOYEE GROUP BY DNO, JOB ORDER BY DNO, JOB;
SELECT MANAGER, JOB, COUNT(*), SUM(SALARY) FROM EMPLOYEE GROUP BY MANAGER, JOB ORDER BY MANAGER, JOB;
--그룹 결과 제한
SELECT DNO, MAX(SALARY) FROM EMPLOYEE GROUP BY DNO HAVING MAX(SALARY) >= 3000;
--현재 근무 일수
--ROUND : 반올림
SELECT ENAME, ROUND(SYSDATE-HIREDATE) AS "근무일수" FROM EMPLOYEE;
--각 사원들이 근무한 개월 수\
--TRUNC : 날짜, 숫자를 자름
--MONTH_BETWEEN(DATE1, DATE2) : DATE1과 DATE2 간의 개월수 계산
SELECT ENAME, SYSDATE, HIREDATE, TRUNC(MONTHS_BETWEEN(SYSDATE, HIREDATE)) AS "WORKING DAY" FROM EMPLOYEE;
--입사한지 6개월 지난 사원
--ADD_MONTHS(DATE, N) : DATE + N개월
SELECT ENAME, HIREDATE, ADD_MONTHS(HIREDATE, 6) FROM EMPLOYEE;
--날짜표시
--TO_CHAR : 날짜, 숫자를 문자로 변환
SELECT ENAME, HIREDATE, TO_CHAR(HIREDATE, 'yy-mm'), TO_CHAR(HIREDATE, 'yyyy/mm/dd day') FROM EMPLOYEE;
--현재 날짜, 시간
--DUAL : 간단하게 함수를 이용해서 계산 결과값을 확인 할 때 사용하는 단순 테이블(오라클 자체 제공)
SELECT TO_CHAR(SYSDATE, 'yyyy/mm/dd, hh24:mi:ss') FROM DUAL;
--통화 기호
--L : 지역별 통화 기호
--0 : 자리수가 맞지 않으면 '0'을 채움
--9 : 자리수가 맞지 않으면 빈자리 무시
SELECT ENAME, TO_CHAR(SALARY, 'L999,999') AS "SALARY" FROM EMPLOYEE;
--1981년 2월 20일 입사한 사원 검색
SELECT ENAME, HIREDATE FROM EMPLOYEE WHERE HIREDATE=TO_DATE(19810220, 'yyyymmdd');
--CASE를 사용하여 이름, 부서명 출력
SELECT ENAME, DNO,
    CASE
        WHEN DNO=10 THEN 'ACCOUNTING'
        WHEN DNO=20 THEN 'RESEARCH'
        WHEN DNO=30 THEN 'SALES'
        WHEN DNO=40 THEN 'OPERATIONS'
        ELSE 'DAFAULT'
    END AS "부서명"
FROM EMPLOYEE ORDER BY DNO;
--DECODE(표현식, 조건N, 결과N, .....기본결과)
--직급이 'ANALYST' 사원은 200, 'SALESMAN' 사원은 180, 'MANAGER' 사원은 150, 'CLERK' 사원은 100 보너스 지급
SELECT ENO, ENAME, JOB, SALARY, DECODE(JOB, 'ANALYST', SALARY + 200, 'SALESMAN', SALARY + 180, 'MANAGER', SALARY + 150, 'CLERK', SALARY + 100, SALARY) AS "보너스 지급" FROM EMPLOYEE;
--부서명, 지역명, 사원수, 모든 사원의 평균 급여 출력
SELECT DECODE(DNO, 10, 'ACCOUNTING', 20, 'RESEARCH', 30, 'SALES', 40, 'OPERATIONS') AS "부서명", DECODE (DNO, 10, 'NEW YORK', 20, 'DALLAS', 30, 'CHICAGO', 40, 'BOSTON') AS "지역", COUNT(*) AS "사원수", ROUND(AVG(SALARY)) AS "평균 급여" FROM EMPLOYEE GROUP BY DNO;
--JOIN 테이블 별칭 사용
SELECT E.ENO, E.ENAME, D.DNAME, E.DNO FROM EMPLOYEE E, DEPARTMENT D WHERE E.DNO = D.DNO AND E.ENO = 7788;
--USING 사용 - INNER JOIN
SELECT E.ENO, E.ENAME, D.DNAME, DNO FROM EMPLOYEE E JOIN DEPARTMENT D USING(DNO) WHERE E.ENO=7788;
--ON 사용 - INNER JOIN
SELECT E.ENO, E.ENAME, D.DNAME, E.DNO FROM EMPLOYEE E JOIN DEPARTMENT D ON E.DNO = D.DNO WHERE E.ENO = 7788;
--3개의 테이블
SELECT E.ENAME, D.DNAME, E.SALARY, S.GRADE FROM EMPLOYEE E, DEPARTMENT D, SALGRADE S WHERE E.DNO = D.DNO AND SALARY BETWEEN LOSAL AND HISAL;
--NATURAL JOIN -  자동으로 공통 컬럼을 조사한 후 JOIN처리
SELECT E.ENO, E.ENAME, D.DNAME, DNO FROM EMPLOYEE E NATURAL JOIN DEPARTMENT D WHERE E.ENO=7788;
--SELF JOIN - 자신의 테이블을 JOIN
SELECT E.ENAME AS "사원", M.ENAME AS "직속상관" FROM EMPLOYEE E, EMPLOYEE M WHERE E.MANAGER = M.ENO;
--LEFT OUTER JOIN - 왼쪽 테이블에 NULL값 존재
SELECT E.ENAME AS "사원", M.ENAME AS "직속상관" FROM EMPLOYEE E LEFT OUTER JOIN EMPLOYEE M ON E.MANAGER = M.ENO;
--이름에 'A'가 포함된 모든 사원과 부서
--NATURAL JOIN
SELECT E.ENAME, D.DNAME FROM EMPLOYEE E NATURAL JOIN DEPARTMENT D WHERE DNO IN(10,20,30,40) AND E.ENAME LIKE '%A%';
--EQUI JOIN(오라클 9i 이전 방식)
SELECT E.ENAME, D.DNAME FROM EMPLOYEE E, DEPARTMENT D WHERE E.DNO = D.DNO AND E.ENAME LIKE '%A%';
--서버 쿼리
SELECT ENAME, DNO FROM EMPLOYEE WHERE DNO=(SELECT DNO FROM EMPLOYEE WHERE ENAME='SCOTT');
--부하직원이 없는 사원
SELECT ENAME FROM EMPLOYEE WHERE ENO IN (SELECT ENO FROM EMPLOYEE WHERE MANAGER IS NULL);
--RESEARCH에서 근무하는 사원
SELECT DNO, ENAME, JOB FROM EMPLOYEE WHERE DNO=(SELECT DNO FROM DEPARTMENT WHERE DNAME='RESEARCH');
--최소 급여를 받는 사원 번호와 이름 출력
SELECT ENO, ENAME FROM EMPLOYEE WHERE SALARY IN (SELECT MIN(SALARY) FROM EMPLOYEE GROUP BY DNO);
--직급이 SALESMAN이 아니면서 급여가 임의의 SALESMAN 보다 낮은 사원 출력
SELECT ENO, ENAME, JOB, SALARY FROM EMPLOYEE WHERE SALARY < ANY(SELECT SALARY FROM EMPLOYEE WHERE JOB='SALESMAN') AND JOB <> 'SALESMAN';
--직급이 SALESMAN이 아니면서 직급이 SALESMAN인 사원보다 급여가 적은 사원 모두 출력
SELECT ENO, ENAME, JOB, SALARY FROM EMPLOYEE WHERE SALARY < ALL(SELECT SALARY FROM EMPLOYEE WHERE JOB='SLESMAN') AND JOB <> 'SALESMAN';