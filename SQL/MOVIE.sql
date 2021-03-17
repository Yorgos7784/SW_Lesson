DROP TABLE MOVIE;
CREATE TABLE MOVIE (NO NUMBER NOT NULL PRIMARY KEY, M_NAME VARCHAR(100) NOT NULL, M_YEAR NUMBER(4) NOT NULL, M_DIRECTOR VARCHAR(100) NOT NULL, M_CASTING VARCHAR(1000), M_REVIEW VARCHAR(20) NOT NULL);

DROP SEQUENCE MOVIE_SEQ;
CREATE SEQUENCE MOVIE_SEQ START WITH 1 INCREMENT BY 1 NOMAXVALUE NOMINVALUE;

INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '타오르는 여인의 초상', 2019, '셀린 시아마', '노에미 멜랑, 아델 에넬', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '시네마 천국', 1988, '쥬세페 토르나토레', '필립 느와레, 실바토레 카시오', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '조커', 2019, '토드 필립스', '호아킨 피닉스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '원스 어폰 어 타임 인... 할리우드', 2019, '쿠엔틴 타란티노','레오나르도 디카프리오, 브래드 피트, 마고 로비', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '기생충', 2019, '봉준호', '송강호, 이선균, 최우식, 조여정, 박소담', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '팬텀 스레드', 2017, '폴 토마스 앤더슨', '다니엘 데이 루이스, 빅키 크리엡스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '더 랍스터', 2015, '요르고스 란티모스', '콜린 파렐, 레이첼 와이즈, 레아 세이두, 올리비아 콜먼, 벤 워쇼', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '카메라를 멈추면 안 돼!', 2018, '우에다 신이치로', '하마츠 타카유키, 아키야마 유즈키, 슈하마 하루미', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '어느 가족', 2018, '고레에다 히로카즈', '릴리 프랭키 안도 사쿠라, 죠 카이리, 키키 키린', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '킬링 디어', 2017, '요르고스 란티모스', '콜린 파렐, 베리 키오건, 니콜 키드먼', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '유전', 2018, '아리 에스터', '토니 콜렛, 알렉스 울프, 밀리 샤피로, 가브리엘 번', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '밀양', 2007, '이창동', '전도연, 송강호', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '셰이프 오브 워터', 2017, '기예르모 델 토로', '셀리 호킨스, 더그 존스, 마이클 섀넌, 옥타비아 스팬서', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '러빙 빈센트', 2017, '도로타 코비엘라, 휴 웰치맨', '더글라스 부스, 시얼샤 로넌, 로버트 굴라직, 제롬 플린', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '라라랜드', 2016, '데미언 셔젤', '라이언 고슬링, 엠마 스톤', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '컨택트', 2017, '드니 빌뇌브', '에이미 아담스, 제레미 레너', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '곡성', 2015, '나홍진', '곽도원, 황정민, 천우희, 쿠니무라 준', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '버드맨', 2014, '알레한드로 곤잘레스 이냐리투', '마이클 키튼, 에드워드 노튼, 나오미 왓츠, 잭 갈러피아나키스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '위플래쉬', 2014, '데미언 셔젤', '마일즈 텔러, J.K.시몬스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '인터스텔라', 2014, '크리스토퍼 놀란', '메튜 맥커너히, 앤 해서웨이, 제시카 차스테인, 마이클 케인', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '더 베터리', 2012, '제레미 가드너', '제레미 가드너, 아담 크론헤임', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '그녀', 2013, '스파이크 존즈', '호아킨 피닉스, 스칼렛 요한슨, 에이미 아담스, 루니 마라', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '그랜드 부다패스트 호텔', 2014, '웨스 앤더슨', '레이프 파인즈, 토니 레볼로리, 틸다 스윈튼, 시얼사 로넌, 애드리안 브로디, 에드워드 노튼, 윌렘 데포', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '파이트 클럽', 1999, '데이빗 핀쳐', '에드워드 노튼, 브레드 피트, 헬레나 본햄 카터', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '메멘토', 2000, '크리스토퍼 놀란', '가이 피어스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '그을린 사랑', 2010, '드니 빌뇌브', '루브나 아자발', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '더 헌트', 2012, '토마스 빈터베르크', '매즈 미켈슨', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '마더', 2009, '봉준호', '원빈, 김혜자, 진구, 윤제문', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '살인의 추억', 2003, '봉준호', '송강호, 김상경, 박해일, 김뢰하', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '판의 미로-오필리아와 세개의 열쇠', 2006, '기예르모 델 토로', '이바나 바쿠에로, 세르지 로페즈, 더그 존스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '성룡의 CIA', 1998, '성룡, 진목승', '성룡', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '킬빌 Vol. 1', 2003, '쿠엔틴 타란티노', '우마 서먼, 루시 리우, 데이비드 캐러딘', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '킬빌 Vol. 2', 2004, '쿠엔틴 타란티노', '우마 서먼, 데이비드 캐러딘', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '라이언 일병 구하기', 1998, '스티븐 스필버그', '톰 행크스, 맷 데이먼', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '호빗-뜻밖의 여정', 2012, '피터 잭슨', '마틴 프리먼, 이안 맥캘런, 리차드 아미티지, 휴고 위빙', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '호빗-스마우그의 폐허', 2013, '피터 잭슨', '마틴 프리먼, 이안 맥캘런, 리차드 아미티지, 휴고 위빙, 베네딕트 컴버배치', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '호빗-다섯 군대 전투', 2014, '피터 잭슨', '마틴 프리먼, 이안 맥캘런, 리차드 아미티지, 휴고 위빙, 베네딕트 컴버배치', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '괴물', 2006, '봉준호', '송강호, 고하성, 변희봉, 박해일, 배두나', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '매트릭스', 1999, '릴리 워쇼스키, 라나 워쇼스키', '키아누 리브스, 로렌스 피쉬번, 캐리 앤 모스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '매트릭스 2-리로디드', 2003, '릴리 워쇼스키, 라나 워쇼스키', '키아누 리브스, 로렌스 피쉬번, 캐리 앤 모스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '매트릭스 3-레볼루션', 2003, '릴리 워쇼스키, 라나 워쇼스키', '키아누 리브스, 로렌스 피쉬번, 캐리 앤 모스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '반지의 제왕-반지원정대', 2001, '피터 잭슨', '이안 맥캘런, 일라이저 우드, 비고 모텐슨, 리브 타일러, 케이트 블란쳇, 휴고 위빙, 앤디 서키스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '반지의 제왕-두개의 탑', 2002, '피터 잭슨', '이안 맥캘런, 일라이저 우드, 비고 모텐슨, 리브 타일러, 케이트 블란쳇, 휴고 위빙, 앤디 서키스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '반지의 제왕-왕의 귀환', 2003, '피터 잭슨', '이안 맥캘런, 일라이저 우드, 비고 모텐슨, 리브 타일러, 케이트 블란쳇, 휴고 위빙, 앤디 서키스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '장고-분노의 추격자', 2012, '쿠엔틴 타란티노', '제이미 폭스, 크리스토프 왈츠, 리오나르도 디카프리오, 사뮤엘.L.잭슨', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '해리포터와 마법사의 돌', 2000, '크리스 콜럼버스', '다니엘 레드클리프, 루퍼트 그린트, 엠마 왓슨', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '해리포터와 비밀의 방', 2002, '크리스 콜럼버스', '다니엘 레드클리프, 루퍼트 그린트, 엠마 왓슨', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '해리포터와 아즈카반의 죄수', 2004, '알폰소 쿠아론', '다니엘 레드클리프, 루퍼트 그린트, 엠마 왓슨, 게리 올드만', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '해리포터와 죽음의 성물 Part.2', 2011, '데이빗 예이츠', '다니엘 레드클리프, 루퍼트 그린트, 엠마 왓슨, 레이프 파인즈', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '터미네이터2-심판의 날', 1991, '제임스 카메론', '아놀드 슈왈제네거, 린다 해밀턴', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '아이언맨', 2008, '존 파브로', '로버트 다우니 주니어, 기네스 펠트로, 제프 브리지스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '러브레터', 1995, '이와이 슌지', '나카야마 미호', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '다크 나이트', 2008, '크리스토퍼 놀란', '크리스찬 베일, 히스 레저, 마이클 케인, 게리 올드만, 아론 에크하트, 메기 질렌할, 모건 프리먼', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '인셉션', 2010, '크리스토퍼 놀란', '레오나르도 디카프리오, 조셉 고든 래빗, 톰 하디, 와타나베 켄, 엘렌 페이지', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '모노노케 히메', 1997, '미야자키 하야오',NULL, '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '노인을 위한 나라는 없다', 2007, '에단 코엔, 조엘 코엔', '하비에르 바르뎀, 조쉬 브롤린, 토미 리 존스', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '토이스토리', 1995, '존 라세티', '톰 행크스, 팀 알렌', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '추격자', 2007, '나홍진', '하정우, 김윤석', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '올드보이', 2003, '박찬욱', '최민식, 유지태, 강혜정', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '원스', 2006, '존 카니', '글랜 핸사드, 마케타 잉글로바', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '이터널 선샤인', 2004, '미셸 공드리', '짐 캐리, 케이트 윈슬릿', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '타짜', 2006, '최동훈', '조승우, 백윤식, 김윤석, 김혜수, 유해진', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '모던 타임즈', 1936, '찰리 채플린', '찰리 채플린, 폴레트 고다드', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '소리도 없이', 2020, '홍의정', '유아인, 유재명, 문승아', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '라이프 오브 파이', 2012, '이안', '수라즈 샤르마, 이르판 칸', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '1917', 2019, '샘 맨데스', '조지 맥케이, 딘-찰스 채프먼, 콜린 퍼스, 마크 스트롱, 베네딕츠 컴버배치', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '결혼 이야기', 2019, '노아 바움백', '스칼렛 요한슨, 아담 드라이버', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '택시 드라이버', 1976, '마틴 스콜세지', '로버트 드 니로', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '더 울프 오브 월 스트리트', 2013, '마틴 스콜세지', '레오나르도 디카프리오, 조나 힐, 매튜 맥커너히', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '플로리다 프로젝트', 2017, '션 베이커', '브루클린 프린스, 브리아 비나이테, 윌렘 데포', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '스파이더맨-뉴 유니버스', 2018, '밥 퍼시케티', '피터 램지, 로드니 로스먼', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '미드 소마', 2019, '아리 에스터', '플로렌스 퓨, 잭 라이너', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '장화, 홍련', 2003, '김지운', '임수정, 문근영, 염정아, 김갑수', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '데어 윌 비 블러드', 2007, '폴 토마스 앤더슨', '다니엘 데이 루이스, 폴 다노', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '바닷마을 다이어리', 2015, '고레에다 히로카즈', '아야세 하루카, 나가사와 마사미, 히로세 스즈', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '세번째 살인', 2017, '고레에다 히로카즈', '후쿠야먀 마사하루, 야쿠쇼 고지, 히로세 스즈', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '가버나움', 2018, '나딘 라바키', '자인 알 라피아', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '시카리오-암살자들의 도시', 2015, '드니 빌뇌브', '에밀리 블론트, 베네치오 델 토로, 조쉬 브롤린', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '쓰리 빌보드', 2017, '마틴 맥도나', '프란시스 맥도먼드, 우디 해럴슨, 샘 록웰', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '펄프 픽션', 1994, '쿠엔틴 타란티노', '존 트라볼타, 사무엘 L. 잭슨, 우마 서먼, 브루스 윌리스', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '버닝', 2018, '이창동', '유아인, 스티븐 연, 전종서', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '어벤져스 : 인피니티 워', 2018, '조 루소, 안소니 루소', '로버트 다우니 주니어, 크리스 에반스, 그리스 햄스워스, 마크 러팔로, 스칼렛 요한슨', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '어벤져스 : 엔드게임', 2019, '조 루소, 안소니 루소', '로버트 다우니 주니어, 크리스 에반스, 그리스 햄스워스, 마크 러팔로, 스칼렛 요한슨', '★★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '코코', 2017, '리 언크리치', '가엘 가르시아 베르날, 안소니 곤잘레스', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '1987', 2017, '장준환', '김윤석, 하정우, 김태리, 유해진, 설경구', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '베르세르크 황금시대편 1-패왕의 알', 2011, '쿠보오카 토시유키', '이와나가 히로아키, 사쿠라이 타카히로', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '베르세르크 황금시대편 2-돌도레이 공략', 2012, '쿠보오카 토시유키', '이와나가 히로아키, 사쿠라이 타카히로', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '베르세르크 황금시대편 3-강림', 2012, '쿠보오카 토시유키', '이와나가 히로아키, 사쿠라이 타카히로', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '언더 더 스킨', 2013, '조나단 글레이셔', '스칼렛 요한슨', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '2001 스페이스 오디세이', 1968, '스탠리 큐브릭', '케어 둘리아, 게리 록우드, 윌리엄 실베스터, 다니엘 리히터', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '옥자', 2017, '봉준호', '틸다 스윈튼, 제이크 질렌할, 폴 다노, 안서현, 스티븐 연', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '싱 스트리트', 2016, '존 카니', '퍼디아 윌시-필로, 루시 보인턴, 잭 레이너', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '밀정', 2016, '김지운', '공유, 송강호, 엄태구', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '아가씨', 2016, '박찬욱', '김태리, 김민희, 하정우, 조진웅', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '헤이트풀 8', 2015, '쿠엔틴 타란티노', '사무엘 L. 잭슨, 컽, 러셀, 제니퍼 제이슨 리, 윌튼 고긴스, 데미안 비쉬어', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '공동경비구역 JSA', 2000, '박찬욱', '송강호, 이병헌, 신하균, 김태우, 이영애', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '베스트 오퍼', 2013, '쥬세페 토르나토레', '제프리 러쉬, 짐 스터지스, 실비아 훅스', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '매드 맥스: 분노의 도로', 2015, '조지 밀러', '톰 하디, 사를리즈 테론, 니콜라스 홀트', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '비긴 어게인', 2013, '존 카니', '키이라 나이틀리, 마크 러팔로, 애덤 리바인', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '아메리칸 스나이퍼', 2014, '클린트 이스트우드', '브래들리 쿠퍼', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '친절한 금자씨', 2005, '박찬욱', '이영애, 최민식', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '라따뚜이', 2007, '브래드 버드', '패튼 오스왈트, 루 로마니', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '복수는 나의 것', 2002, '박찬욱', '송강호, 신하균, 배두나', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '가디언즈 오브 갤럭시', 2014, '제임스 건', '크리스 프렛, 조 샐다나, 데이브 바티스타, 브래들리 쿠퍼, 빈 디젤', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '가장 따뜻한 색 블루', 2013, '압델라티프 케시시', '아델 엑사르쇼폴로스, 레아 세이두', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '뷰티풀 마인드', 2001, '론 하워드', '러셀 크로우, 에드 해리스, 제니퍼 코넬리', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '양들의 침묵', 1991, '조나단 드미', '안소니 홉킨스, 조디 포스터', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '달라스 바이어스 클럽', 2013, '장 마크 발레', '매튜 맥거너히, 자레드 레토', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '하울의 움직이는 성', 2004, '미야자키 하야오', '바이쇼 치에코, 기무라 타쿠야', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '유주얼 서스펙트', 1995, '브라이언 싱어', '채즈 팰민테리, 케빈 스페이시, 베니시오 델 토로', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '세븐', 1995, '데이빗 핀쳐', '브래드 피트, 모건 프리먼, 기네스 펠트로, 케빈 스페이시', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '트루먼 쇼', 1998, '피터 위어', '짐 캐리, 에드 해리스, 로라 리니, 나타샤 맥켈혼', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '케빈에 대하여', 2011, '린 램지', '틸다 스윈튼, 애즈라 밀러', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '캐치 미 이프 유 캔', 2002, '스티븐 스필버그', '레오나르도 디카프리오, 톰 행크스', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '시계  태엽 오랜지', 1971, '스탠리 큐브릭', '말콤 맥도웰, 패트릭 마지', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '고백', 2010, '나카시마 테츠야', '마츠 다카코, 기무라 요시노, 오카다 마사키', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '밴자민 버튼의 시간은 거꾸로 간다', 2008, '데이빗 핀쳐', '브래드 피트, 케이트 블란쳇', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '어바웃 타임', 2013, '리처드 커티스', '도널 글리슨, 레이첼 맥아담스', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '센과 치히로의 행방불명', 2001, '미야자키 하야오', '히이라기 루미, 나츠키 마리, 이리노 미유', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '28일 후', 2002, '대니 보일', '킬리언 머피, 나오미 해리스, 브랜단 글리슨', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '에이리언', 1979, '리들리 스콧', '시고니 위버, 존 허트, 톰 스커릿', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '127시간', 2010, '대니 보일', '제임스 프랭코', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '소셜 네트워크', 2010, '데이빗 핀쳐', '제시 아이젠버그, 앤드류 가필드, 저스틴 팀버레이크', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '팅커 테일러 솔져 스파이', 2011, '토마스 알프레드슨', '게리 올드만, 콜린 퍼스, 톰 하디, 마크 스트롱, 키이란 하인즈', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '콘스탄틴', 2005, '프란시스 로렌스', '키아누 리브스, 레이첼 바이스, 샤아아 라보프, 틸다 스윈튼', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '토이스토리3', 2010, '리 언크리치', '톰 행크스, 팀 알렌', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '월-E', 2008, '앤드류 스탠튼', '벤 버트, 엘리사 나이트', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '설국열차', 2013, '봉준호', '크리스 에반스, 송강호, 틸다 스윈튼, 존 허트, 에드 해리슨', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '스위니 토드: 어느 잔혹한 이발사 이야기', 2007, '팀 버튼', '조니 뎁, 헬레나 본햄 카터, 엘런 릭맨', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '브이 포 벤데타', 2005, '제임스 맥테이그', '나탈리 포트만, 휴고 위빙', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '향수-어느 살인자의 이야기', 2006, '톰 티크베어', '벤 위쇼, 더스틴 호프만, 앨런 릭먼', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '박쥐', 2009, '박찬욱', '송강호, 김옥빈, 신하균, 김해숙', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '그래비티', 2013, '알폰소 쿠아론', '산드라 블록, 조지 클루니', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '셔터 아일랜드', 2010, '마틴 스콜세지', '레오나르도 디카프리오, 마크 러팔로, 미셸 윌리엄스', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '파수꾼', 2010, '윤셩현', '이제훈, 서준영, 박정민, 조성하', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '쇼생크 탈출', 1994, '프랭크 다라본트', '팀 로빈스, 모건 프리먼', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '줄무늬 파자마를 입은 소년', 2008, '마크 허만', '에이사 버터필드, 잭 스캔론, 베라 파미가, 데이빗 듈리스', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '달콤한 인생', 2005, '김지운', '이병헌, 신민아, 김영철', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '타이타닉', 1997, '제임스 카메론', '레오나르도 디카프리오, 케이트 윈슬릿', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '지구를 지켜라!', 2003, '장준환', '신하균, 백윤식', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '지금, 만나러 갑니다', 2004, '도이 노부히로', '타케우치 유코, 나카무라 시도', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '세 얼간이', 2009, '라지쿠마르 히라니', '아미르 칸, 마드하반, 셔먼 조쉬', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '4월 이야기', 1998, '이와이 슌지', '마츠 다카코, 다나베 세이치', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '레옹', 1994, '뤽 베송', '장 르노, 나탈리 포드만, 개리 올드만', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '황해', 2010, '나홍진', '하정우, 김윤석, 조성하', '★★★★☆');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '서던 리치: 소멸의 땅', 2018, '알렉스 갈랜드', '나탈리 포트만, 제니퍼 제이슨 리, 테사 톰슨, 오스카 아이작', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '스타워즈 에피소드4: 새로운 희망', 1977, '조지 루카스', '마크 해밀, 해리슨 포드, 캐리 피셔', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '스타워즈 에피소드5: 제국의 역습', 1980, '조지 루카스', '마크 해밀, 해리슨 포드, 캐리 피셔', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '스타워즈 에피소드6: 제다이의 귀환', 1983, '조지 루카스', '마크 해밀, 해리슨 포드, 캐리 피셔', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '런', 2020, '이나쉬 차칸티', '사라 폴슨, 키에라 앨런', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '테넷', 2020, '크리스토퍼 놀란', '존 데이비드 워싱턴, 로버트 패틴슨, 엘리자베스 데비키, 케네스 브래너', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '지푸라기라도 잡고 싶은 짐승들', 2018, '김용훈', '전도연, 정우성, 배성우, 윤여정, 신현빈', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '인비저블맨', 2020, '리 워넬', '엘리자베스 모스, 올리버 잭슨-코헨', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '조조래빗', 2019, '타이카 와이티티', '로먼 그리핀 데이비스, 토마신 맥캔지, 스칼렛 요한슨, 타이카 와이티티', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '포드 V 페라리', 2019, '제임스 맨골드', '크리스찬 베일, 맷 데이먼', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '나이브스 아웃', 2019, '라이언 존슨', '아나 드 아르마스, 다니엘 크레이그, 크리스 에반스, 마이클 섀넌, 제이미 리 커티스, 토니 콜렛', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '작은 아씨들', 2019, '그레타 거윅', '시얼샤 로넌, 엠마 왓슨, 플로렌스 퓨, 티모시 살라메', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '남산의 부장들', 2019, '우민호', '이병헌, 곽도원, 이성민, 이희준', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '애드 아스트라', 2019, '제임스 그레이', '브래드 피트, 토미 리 존스', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '라이온 킹', 1994, '로저 알러스, 롭 민코프', '매튜 브로데릭, 제임스 얼 존스, 제레미 아이언스', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '스파이더맨: 파 프롬 홈', 2019, '존 왓츠', '톰 홀랜드, 제이크 질렌할, 사무엘 L. 잭슨', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '토이 스토리4', 2019, '조시 쿨리', '톰 행크스, 팀 알렌, 애니 포츠', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '빅 쇼트', 2015, '아담 맥케이', '크리스찬 베일, 스티브 카렐, 라이언 고슬링, 브래드 피트', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '미셩년', 2018, '김윤석', '김예준, 박세진, 염정아, 김소진, 김윤석', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '더 길티', 2018, '구스타브 몰러', '야곱 세데르그렌', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '그린 북', 2018, '피터 패럴리', '비고 모텐슨, 마허살라 알리', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '어스', 2019, '조던 필', '루피타 니옹고, 윈스턴 듀크', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '더 페이버릿: 여왕의 여자', 2018, '요르고스 란티모스', '엠마 스톤, 올리비아 콜먼, 레이첼 바이즈, 니콜라스 홀트', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '사바하', 2019, '장재현', '이정재, 박정민, 이재인', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '미행', 1998, '크리스토퍼 놀란', '제레미 데오발드, 존 놀란', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '킹덤 오브 헤븐', 2005, '리들리 스콧', '올란도 블룸, 에바 그린, 리암 니슨, 제레미 아이언스', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '할로윈', 2018, '데이빗 고든 그린', '제이미 리 커티스, 주디 그리어, 제퍼슨 홀', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '퍼스트 맨', 2018, '데이언 셔젤', '라이언 고슬링, 클레어 포이', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '암수살인', 2018, '김태균', '김윤석, 주지훈', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '서치', 2018, '이나쉬 차칸티', '존 조, 데브라 메싱, 미셸 라', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '업그레이드', 2018, '리 워넬', '로건 마샬그린', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '현기증', 1958, '알프레드 히치콕', '제임스 스튜어트, 킴 노박', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '엑소시스트', 1973, '윌리엄 프레드킨', '제이슨 밀러, 린다 블레어, 엘렌 버스틴, 막스 폰 시도우', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '북북서로 진로를 돌려라', 1959, '알프레드 히치콕', '캐리 그랜트, 에바 마리 세인트', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '배드 지니어스', 2017, '나타우트 폰피리야', '추티몬 추엥차로엔수키잉, 차논 산티네톤쿨, 에이샤 호수완, 티라돈 수파펀핀요', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '공작', 2018, '윤종빈', '황정민, 이성민, 조진웅, 주지훈', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '미션 임파서블: 폴아웃', 2018, '크리스토퍼 맥쿼리', '톰 크루즈, 헨리 카빌, 사이먼 페그, 빙 레임스, 안젤라 바셋', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '대부', 1972, '프란시스 포드 코폴라', '말론 브란도, 알 파치노, 제임스 칸', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '콰이어트 플레이스', 2018, '존 크라신스키', '에밀리 블런트, 존 크라신스키, 노아 주프, 밀리센트 시몬즈', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '레디 플레이어 원', 2018, '스티븐 스필버그', '타이 셰리던, 올리비아 쿡, 벤 멘델존, 사이먼 페그, 마크 라이런스', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '나는 내일, 어제의 너와 만난다', 2016, '미키 타카히로', '후쿠시 소타, 고마츠 나나, 히가시데 마시히로', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '오션스 일레븐', 2001, '스티븐 소더버그', '조지 클루니, 브레드 피트, 돈 치들, 맷 데이먼, 앤디 가르시아, 케이시 애플렉', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '윈드 리버', 2017, '테일러 쉐리던', '제레미 레너, 엘리자베스 올슨, 존 번탈', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '토르: 라그나로크', 2017, '타이카 와이티티', '크리스 햄스워스, 톰 히들스턴, 테사 톰슨, 케이트 블란쳇', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '블레이드 러너 2049', 2017, '드니 빌뇌브', '라이언 고슬링, 해리슨 포드, 아나 드 아르마스, 자레드 레토', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '남한산성', 2017, '황동혁', '이병헌, 김윤석, 박해일, 고수, 박희순', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '베이비 드라이버', 2017, '에드가 라이트', '안셀 엘고트, 릴리 제임스, 존 햄, 제이미 폭스, 에이사 곤살레스, 케빈 스페이시', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '아토믹 블론드', 2017, '데이빗 레이치', '샤를리즈 테론, 제임스 맥어보이, 소피아 부텔라, 존 굿맨', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '덩케르크', 2017, '크리스토퍼 놀란', '핀 화이트헤드, 마크 라이런스, 톰 하디, 해리 스타일스, 케네스 브래너', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '스파이더맨: 홈커밍', 2017, '존 왓츠', '톰 홀랜드, 마이클 키튼, 로버트 다우니 주니어', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '이벤트 호라이즌', 1997, '폴 W.S. 앤더슨', '로렌스 피쉬번, 샘 닐, 캐슬린 퀀런, 리처드 T. 존스, 조엘리 리처드슨', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '겟 아웃', 2017, '조던 필', '다니엘 칼루야, 앨리슨 윌리엄스, 브래들리 윗포드, 캐서린 키너', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '불한당: 나쁜 놈들의 세상', 2016, '변성현', '셜경구, 임시환, 김희원, 전혜진, 이경영', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '에이리언: 커버넌트', 2017, '리들리 스콧', '마이클 패스벤더, 캐서린 워터스턴, 빌리 크루덥', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '은하수를 여행하는 히치하이커를 위한 안내서', 2005, '가스 제닝스', '마틴 프리먼, 샘 록웰, 모스 데프, 주이 디샤넬', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '23 아이덴티티', 2016, 'M. 나이트 샤말란', '제임스 맥어보이, 안야 테일러 조이', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '로건', 2017, '제임스 맨골드', '휴 잭맨, 다프네 킨, 패트릭 스튜어트', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '존 윅', 2014, '데이빗 리이치, 채드 스타헬스키', '키아누 리브스, 윌렘 데포, 알피 알렌, 미카엘 니크비스트', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '존 윅2: 리로드', 2017, '채드 스타헬스키', '키아누 리브스, 루비 로즈, 이안 맥쉐인, 로렌스 피쉬번', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '너의 이름은', 2016, '신카이 마코토', '카미키 류노스케, 카미시라이시 모네', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '파이란', 2001, '송해성', '최민식, 장백지, 손병호', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '연애담', 2016, '이현주', '이상희, 류아벨', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '더 킹', 2017, '한재림', '조인성, 정우성, 배성우, 류준열', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '아이덴티티', 2003, '제임스 맨골드', '존 쿠삭, 레이 이로타, 아만다  피트, 존 C. 맥긴리, 클리어 듀발', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '클로버필드 10번지', 2016, '댄 트라첸버그', '메리 엘리자베스 윈스티드, 존 굿맨, 존 갤러거 주니어, 브래들리 쿠퍼', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '로그 원: 스타워즈 스토리', 2016, '가렛 에드워즈', '펠리시티 존스, 디에고 루나, 알란 튜딕, 견자단, 강문', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '신비한 동물사전', 2016, '데이빗 예이츠', '에디 레드메인, 캐서린 워터스턴, 콜린 파렐, 앨리슨 수돌, 댄 포글러, 애즈라 밀러', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '맨 인 더 다크', 2016, '페데리코 알바레즈', '제인 레비, 딜런 미넷, 스티블 앨, 다니엘 조바토', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '닥터 스트레인지', 2016, '스콧 데릭슨', '베네딕트 컴버배치, 틸다 스윈튼, 레이첼 맥아담스, 매즈 미켈슨, 치웨텔 에지오포, 베네딕트 웡', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '아수라', 2016, '김성수', '정우성, 황정민, 주지훈, 곽도원, 정만식', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '와호장룡', 2000, '이안', '주윤발, 양자경, 장쯔이, 장첸', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '카고', 2013, '벤 하울링, 욜란다 람케', '앤디 로더레다', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '마터스: 천국을 보는 눈', 2008, '파스칼 로지에', '모르자나 아나위, 밀레느 잠파노이', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '부산행', 2016, '연상호', '공유, 정유미, 마동석, 김수안, 김의성', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '늑대아이', 2012, '호소다 마모루', '미야자키 아오이, 오사와 타카오, 쿠로키 하루, 니시이 유키토, 오노 모모카', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '나의 소녀시대', 2015, '프랭키 첸', '송운화, 왕대륙', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '주토피아', 2016, '바이론 하워드, 리치 무어', '지니퍼 굿윈, 제이슨 베이트먼', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '더 저지', 2014, '데이빗 돕킨', '로버트 다우니 주니어, 로버트 듀발, 베라 파미가', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '범죄의 재구성', 2004, '최동훈', '박신양, 백윤식, 염정아, 이문식', '★★★★');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '나이트 크롤러', 2014, '댄 길로이', '제이크 질렌할, 르네 루소, 리즈 아메드', '★★★★');