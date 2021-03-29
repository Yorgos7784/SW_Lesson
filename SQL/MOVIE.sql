DROP TABLE MOVIE;
CREATE TABLE MOVIE (NO NUMBER NOT NULL PRIMARY KEY, M_NAME VARCHAR(100) NOT NULL, M_YEAR NUMBER(4) NOT NULL, M_DIRECTOR VARCHAR(100) NOT NULL, M_CASTING VARCHAR(1000), M_REVIEW VARCHAR(20) NOT NULL);

DROP SEQUENCE MOVIE_SEQ;
CREATE SEQUENCE MOVIE_SEQ START WITH 1 INCREMENT BY 1 NOMAXVALUE NOMINVALUE;

INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'Ÿ������ ������ �ʻ�', 2019, '���� �þƸ�', '�뿡�� ���, �Ƶ� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ó׸� õ��', 1988, '�꼼�� �丣���䷹', '�ʸ� ���ͷ�, �ǹ��䷹ ī�ÿ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��Ŀ', 2019, '��� �ʸ���', 'ȣ��Ų �Ǵн�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ���� �� Ÿ�� ��... �Ҹ����', 2019, '����ƾ Ÿ��Ƽ��','���������� ��ī������, �귡�� ��Ʈ, ���� �κ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�����', 2019, '����ȣ', '�۰�ȣ, �̼���, �ֿ��, ������, �ڼҴ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ������', 2017, '�� �丶�� �ش���', '�ٴϿ� ���� ���̽�, ��Ű ũ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ������', 2015, '�丣���� ��Ƽ��', '�ݸ� �ķ�, ����ÿ ������, ���� ���̵�, �ø���� �ݸ�, �� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ī�޶� ���߸� �� ��!', 2018, '�쿡�� ����ġ��', '�ϸ��� Ÿī��Ű, ��Ű�߸� ����Ű, ���ϸ� �Ϸ��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��� ����', 2018, '�������� ����ī��', '���� ����Ű �ȵ� ������, �� ī�̸�, ŰŰ Ű��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ų�� ���', 2017, '�丣���� ��Ƽ��', '�ݸ� �ķ�, ���� Ű����, ���� Ű���', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2018, '�Ƹ� ������', '��� �ݷ�, �˷��� ����, �и� ���Ƿ�, ���긮�� ��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�о�', 2007, '��â��', '������, �۰�ȣ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ���� ����', 2017, '�⿹���� �� ���', '���� ȣŲ��, ���� ����, ����Ŭ ����, ��Ÿ��� ���Ҽ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ��Ʈ', 2017, '����Ÿ �ں񿤶�, �� ��ġ��', '���۶� �ν�, �þ�� �γ�, �ι�Ʈ ������, ���� �ø�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��󷣵�', 2016, '���̾� ����', '���̾� ������, ���� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����Ʈ', 2017, '��� ������', '���̹� �ƴ㽺, ������ ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�', 2015, '��ȫ��', '������, Ȳ����, õ����, ���Ϲ��� ��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�����', 2014, '�˷��ѵ�� ���߷��� �̳ĸ���', '����Ŭ Űư, ������� ��ư, ������ ����, �� �����ǾƳ�Ű��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���÷���', 2014, '���̾� ����', '������ �ڷ�, J.K.�ø�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ͽ��ڶ�', 2014, 'ũ�������� ���', '��Ʃ ��Ŀ����, �� �ؼ�����, ����ī ��������, ����Ŭ ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ���͸�', 2012, '������ �����', '������ �����, �ƴ� ũ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�׳�', 2013, '������ũ ����', 'ȣ��Ų �Ǵн�, ��Į�� ���ѽ�, ���̹� �ƴ㽺, ��� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�׷��� �δ��н�Ʈ ȣ��', 2014, '���� �ش���', '������ ������, ��� �����θ�, ƿ�� ����ư, �þ�� �γ�, �ֵ帮�� ��ε�, ������� ��ư, ���� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����Ʈ Ŭ��', 1999, '���̺� ����', '������� ��ư, �극�� ��Ʈ, �ﷹ�� ���� ī��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�޸���', 2000, 'ũ�������� ���', '���� �Ǿ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ���', 2010, '��� ������', '��곪 ���ڹ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ��Ʈ', 2012, '�丶�� ���ͺ���ũ', '���� ���̽�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2009, '����ȣ', '����, ������, ����, ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ �߾�', 2003, '����ȣ', '�۰�ȣ, ����, ������, �����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� �̷�-���ʸ��ƿ� ������ ����', 2006, '�⿹���� �� ���', '�̹ٳ� ��������, ������ ������, ���� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ CIA', 1998, '����, �����', '����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ų�� Vol. 1', 2003, '����ƾ Ÿ��Ƽ��', '�츶 ����, ��� ����, ���̺�� ĳ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ų�� Vol. 2', 2004, '����ƾ Ÿ��Ƽ��', '�츶 ����, ���̺�� ĳ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̾� �Ϻ� ���ϱ�', 1998, '��Ƽ�� ���ʹ���', '�� ��ũ��, �� ���̸�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ȣ��-����� ����', 2012, '���� �轼', '��ƾ ������, �̾� ��Ķ��, ������ �ƹ�Ƽ��, �ް� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ȣ��-��������� ����', 2013, '���� �轼', '��ƾ ������, �̾� ��Ķ��, ������ �ƹ�Ƽ��, �ް� ����, ���׵�Ʈ �Ĺ���ġ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ȣ��-�ټ� ���� ����', 2014, '���� �轼', '��ƾ ������, �̾� ��Ķ��, ������ �ƹ�Ƽ��, �ް� ����, ���׵�Ʈ �Ĺ���ġ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2006, '����ȣ', '�۰�ȣ, ���ϼ�, �����, ������, ��γ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��Ʈ����', 1999, '���� ���Ű, �� ���Ű', 'Ű�ƴ� ���꽺, �η��� �ǽ���, ĳ�� �� ��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��Ʈ���� 2-���ε��', 2003, '���� ���Ű, �� ���Ű', 'Ű�ƴ� ���꽺, �η��� �ǽ���, ĳ�� �� ��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��Ʈ���� 3-�������', 2003, '���� ���Ű, �� ���Ű', 'Ű�ƴ� ���꽺, �η��� �ǽ���, ĳ�� �� ��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ����-����������', 2001, '���� �轼', '�̾� ��Ķ��, �϶����� ���, ��� ���ٽ�, ���� Ÿ�Ϸ�, ����Ʈ ������, �ް� ����, �ص� ��Ű��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ����-�ΰ��� ž', 2002, '���� �轼', '�̾� ��Ķ��, �϶����� ���, ��� ���ٽ�, ���� Ÿ�Ϸ�, ����Ʈ ������, �ް� ����, �ص� ��Ű��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ����-���� ��ȯ', 2003, '���� �轼', '�̾� ��Ķ��, �϶����� ���, ��� ���ٽ�, ���� Ÿ�Ϸ�, ����Ʈ ������, �ް� ����, �ص� ��Ű��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���-�г��� �߰���', 2012, '����ƾ Ÿ��Ƽ��', '���̹� ����, ũ�������� ����, ���������� ��ī������, ��¿�.L.�轼', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ظ����Ϳ� �������� ��', 2000, 'ũ���� �ݷ�����', '�ٴϿ� ����Ŭ����, ����Ʈ �׸�Ʈ, ���� �ӽ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ظ����Ϳ� ����� ��', 2002, 'ũ���� �ݷ�����', '�ٴϿ� ����Ŭ����, ����Ʈ �׸�Ʈ, ���� �ӽ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ظ����Ϳ� ����ī���� �˼�', 2004, '������ ���Ʒ�', '�ٴϿ� ����Ŭ����, ����Ʈ �׸�Ʈ, ���� �ӽ�, �Ը� �õ常', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ظ����Ϳ� ������ ���� Part.2', 2011, '���̺� ������', '�ٴϿ� ����Ŭ����, ����Ʈ �׸�Ʈ, ���� �ӽ�, ������ ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�͹̳�����2-������ ��', 1991, '���ӽ� ī�޷�', '�Ƴ�� �������װ�, ���� �ع���', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̾��', 2008, '�� �ĺ��', '�ι�Ʈ �ٿ�� �ִϾ�, ��׽� ��Ʈ��, ���� �긮����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���극��', 1995, '�̿��� ����', '��ī�߸� ��ȣ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��ũ ����Ʈ', 2008, 'ũ�������� ���', 'ũ������ ����, ���� ����, ����Ŭ ����, �Ը� �õ常, �Ʒ� ��ũ��Ʈ, �ޱ� ������, ��� ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�μ���', 2010, 'ũ�������� ���', '���������� ��ī������, ���� ���� ����, �� �ϵ�, ��Ÿ���� ��, ���� ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ����', 1997, '�̾���Ű �Ͼ߿�',NULL, '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ���� ����� ����', 2007, '���� �ڿ�, ���� �ڿ�', '�Ϻ񿡸� �ٸ���, ���� ��Ѹ�, ��� �� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̽��丮', 1995, '�� ��Ƽ', '�� ��ũ��, �� �˷�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�߰���', 2007, '��ȫ��', '������, ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�õ庸��', 2003, '������', '�ֹν�, ������, ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2006, '�� ī��', '�۷� �ڻ��, ����Ÿ �ױ۷ι�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ͳ� ������', 2004, '�̼� ���帮', '�� ĳ��, ����Ʈ ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'Ÿ¥', 2006, '�ֵ���', '���¿�, ������, ������, ������, ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��� Ÿ����', 1936, '���� ä�ø�', '���� ä�ø�, ����Ʈ ���ٵ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�Ҹ��� ����', 2020, 'ȫ����', '������, �����, ���¾�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ���� ����', 2012, '�̾�', '������ ������, �̸��� ĭ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '1917', 2019, '�� �ǵ���', '���� ������, ��-���� ä����, �ݸ� �۽�, ��ũ ��Ʈ��, ���׵��� �Ĺ���ġ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��ȥ �̾߱�', 2019, '��� �ٿ��', '��Į�� ���ѽ�, �ƴ� ����̹�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ý� ����̹�', 1976, '��ƾ ���ݼ���', '�ι�Ʈ �� �Ϸ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ���� ���� �� ��Ʈ��Ʈ', 2013, '��ƾ ���ݼ���', '���������� ��ī������, ���� ��, ��Ʃ ��Ŀ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�÷θ��� ������Ʈ', 2017, '�� ����Ŀ', '���Ŭ�� ������, �긮�� ������, ���� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�����̴���-�� ���Ϲ���', 2018, '�� �۽���Ƽ', '���� ����, �ε�� �ν���', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�̵� �Ҹ�', 2019, '�Ƹ� ������', '�÷η��� ǻ, �� ���̳�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��ȭ, ȫ��', 2003, '������', '�Ӽ���, ���ٿ�, ������, �谩��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� �� �� ������', 2007, '�� �丶�� �ش���', '�ٴϿ� ���� ���̽�, �� �ٳ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ٴ帶�� ���̾', 2015, '�������� ����ī��', '�ƾ߼� �Ϸ�ī, ������� �����, ���μ� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����° ����', 2017, '�������� ����ī��', '�����߸� �����Ϸ�, ������ ����, ���μ� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��������', 2018, '���� ���Ű', '���� �� ���Ǿ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��ī����-�ϻ��ڵ��� ����', 2015, '��� ������', '���и� ����Ʈ, ����ġ�� �� ���, ���� ��Ѹ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ������', 2017, '��ƾ �Ƶ���', '�����ý� �Ƶ��յ�, ��� �ط���, �� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� �ȼ�', 1994, '����ƾ Ÿ��Ƽ��', '�� Ʈ��Ÿ, �繫�� L. �轼, �츶 ����, ��罺 ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2018, '��â��', '������, ��Ƽ�� ��, ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����� : ���Ǵ�Ƽ ��', 2018, '�� ���, �ȼҴ� ���', '�ι�Ʈ �ٿ�� �ִϾ�, ũ���� ���ݽ�, �׸��� �ܽ�����, ��ũ ���ȷ�, ��Į�� ���ѽ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����� : �������', 2019, '�� ���, �ȼҴ� ���', '�ι�Ʈ �ٿ�� �ִϾ�, ũ���� ���ݽ�, �׸��� �ܽ�����, ��ũ ���ȷ�, ��Į�� ���ѽ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2017, '�� ��ũ��ġ', '���� �����þ� ������, �ȼҴ� ���߷���', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '1987', 2017, '����ȯ', '������, ������, ���¸�, ������, ���汸', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��������ũ Ȳ�ݽô��� 1-�п��� ��', 2011, '������ī �����Ű', '�̿ͳ��� ���ξ�Ű, �������� Ÿī����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��������ũ Ȳ�ݽô��� 2-�������� ����', 2012, '������ī �����Ű', '�̿ͳ��� ���ξ�Ű, �������� Ÿī����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��������ũ Ȳ�ݽô��� 3-����', 2012, '������ī �����Ű', '�̿ͳ��� ���ξ�Ű, �������� Ÿī����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��� �� ��Ų', 2013, '������ �۷��̼�', '��Į�� ���ѽ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '2001 �����̽� ������', 1968, '���ĸ� ť�긯', '�ɾ� �Ѹ���, �Ը� �Ͽ��, ������ �Ǻ�����, �ٴϿ� ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2017, '����ȣ', 'ƿ�� ����ư, ����ũ ������, �� �ٳ�, �ȼ���, ��Ƽ�� ��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ��Ʈ��Ʈ', 2016, '�� ī��', '�۵�� ����-�ʷ�, ��� ������, �� ���̳�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2016, '������', '����, �۰�ȣ, ���±�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ư���', 2016, '������', '���¸�, �����, ������, ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����ƮǮ 8', 2015, '����ƾ Ÿ��Ƽ��', '�繫�� L. �轼, ��, ����, ������ ���̽� ��, ��ư ���佺, ���̾� �񽬾�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������񱸿� JSA', 2000, '������', '�۰�ȣ, �̺���, ���ϱ�, ���¿�, �̿���', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����Ʈ ����', 2013, '�꼼�� �丣���䷹', '������ ����, �� ��������, �Ǻ�� �Ž�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ŵ� �ƽ�: �г��� ����', 2015, '���� �з�', '�� �ϵ�, �縦���� �׷�, ���ݶ� ȦƮ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��� �����', 2013, '�� ī��', 'Ű�̶� ����Ʋ��, ��ũ ���ȷ�, �ִ� ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�Ƹ޸�ĭ ��������', 2014, 'Ŭ��Ʈ �̽�Ʈ���', '�귡�鸮 ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ģ���� ���ھ�', 2005, '������', '�̿���, �ֹν�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�������', 2007, '�귡�� ����', '��ư ������Ʈ, �� �θ���', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ���� ��', 2002, '������', '�۰�ȣ, ���ϱ�, ��γ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������� ���� ������', 2014, '���ӽ� ��', 'ũ���� ����, �� ���ٳ�, ���̺� ��Ƽ��Ÿ, �귡�鸮 ����, �� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ������ �� ����', 2013, '�е���Ƽ�� �ɽý�', '�Ƶ� ���縣�����ν�, ���� ���̵�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��ƼǮ ���ε�', 2001, '�� �Ͽ���', '���� ũ�ο�, ���� �ظ���, ������ �ڳڸ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����� ħ��', 1991, '������ ���', '�ȼҴ� ȩŲ��, ���� ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�޶� ���̾ Ŭ��', 2013, '�� ��ũ �߷�', '��Ʃ �ưų���, �ڷ��� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�Ͽ��� �����̴� ��', 2004, '�̾���Ű �Ͼ߿�', '���̼� ġ����, �⹫�� Ÿ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���־� ������Ʈ', 1995, '����̾� �̾�', 'ä�� �ӹ��׸�, �ɺ� �����̽�, ���Ͻÿ� �� ���', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 1995, '���̺� ����', '�귡�� ��Ʈ, ��� ������, ��׽� ��Ʈ��, �ɺ� �����̽�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'Ʈ��� ��', 1998, '���� ����', '�� ĳ��, ���� �ظ���, �ζ� ����, ��Ÿ�� ����ȥ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ɺ� ���Ͽ�', 2011, '�� ����', 'ƿ�� ����ư, ����� �з�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ĳġ �� ���� �� ĵ', 2002, '��Ƽ�� ���ʹ���', '���������� ��ī������, �� ��ũ��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ð�  �¿� ������', 1971, '���ĸ� ť�긯', '���� �Ƶ���, ��Ʈ�� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2010, '��ī�ø� ������', '���� ��ī��, �⹫�� ��ó�, ��ī�� ����Ű', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ڹ� ��ư�� �ð��� �Ųٷ� ����', 2008, '���̺� ����', '�귡�� ��Ʈ, ����Ʈ ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��ٿ� Ÿ��', 2013, '��ó�� ĿƼ��', '���� �۸���, ����ÿ �ƾƴ㽺', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ġ������ ���Ҹ�', 2001, '�̾���Ű �Ͼ߿�', '���̶�� ���, ����Ű ����, �̸��� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '28�� ��', 2002, '��� ����', 'ų���� ����, ������ �ظ���, �귣�� �۸���', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̸���', 1979, '���鸮 ����', '�ð��� ����, �� ��Ʈ, �� ��Ŀ��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '127�ð�', 2010, '��� ����', '���ӽ� ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�Ҽ� ��Ʈ��ũ', 2010, '���̺� ����', '���� ����������, �ص�� ���ʵ�, ����ƾ ��������ũ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��Ŀ ���Ϸ� ���� ������', 2011, '�丶�� �������彼', '�Ը� �õ常, �ݸ� �۽�, �� �ϵ�, ��ũ ��Ʈ��, Ű�̶� ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ܽ�źƾ', 2005, '�����ý� �η���', 'Ű�ƴ� ���꽺, ����ÿ ���̽�, ���ƾ� ����, ƿ�� ����ư', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̽��丮3', 2010, '�� ��ũ��ġ', '�� ��ũ��, �� �˷�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��-E', 2008, '�ص�� ����ư', '�� ��Ʈ, ������ ����Ʈ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��������', 2013, '����ȣ', 'ũ���� ���ݽ�, �۰�ȣ, ƿ�� ����ư, �� ��Ʈ, ���� �ظ���', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ���: ��� ��Ȥ�� �̹߻� �̾߱�', 2007, '�� ��ư', '���� ��, �ﷹ�� ���� ī��, ���� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� �� ����Ÿ', 2005, '���ӽ� �����̱�', '��Ż�� ��Ʈ��, �ް� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���-��� �������� �̾߱�', 2006, '�� Ƽũ����', '�� ����, ����ƾ ȣ����, �ٷ� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2009, '������', '�۰�ȣ, �����, ���ϱ�, ���ؼ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�׷���Ƽ', 2013, '������ ���Ʒ�', '���� ����, ���� Ŭ���', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ���Ϸ���', 2010, '��ƾ ���ݼ���', '���������� ��ī������, ��ũ ���ȷ�, �̼� ��������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ļ���', 2010, '������', '������, ���ؿ�, ������, ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ũ Ż��', 1994, '����ũ �ٶ�Ʈ', '�� �κ�, ��� ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ٹ��� ���ڸ��� ���� �ҳ�', 2008, '��ũ �㸸', '���̻� �����ʵ�, �� ��ĵ��, ���� �Ĺ̰�, ���̺� �⸮��', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ �λ�', 2005, '������', '�̺���, �Źξ�, �迵ö', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'Ÿ��Ÿ��', 1997, '���ӽ� ī�޷�', '���������� ��ī������, ����Ʈ ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ ���Ѷ�!', 2003, '����ȯ', '���ϱ�, ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����, ������ ���ϴ�', 2004, '���� �������', 'Ÿ�ɿ�ġ ����, ��ī���� �õ�', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ����', 2009, '���������� �����', '�ƹ̸� ĭ, �����Ϲ�, �Ÿ� ����', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '4�� �̾߱�', 1998, '�̿��� ����', '���� ��ī��, �ٳ��� ����ġ', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 1994, '�� ����', '�� ����, ��Ż�� ���常, ���� �õ常', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'Ȳ��', 2010, '��ȫ��', '������, ������, ������', '�ڡڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ��ġ: �Ҹ��� ��', 2018, '�˷��� ������', '��Ż�� ��Ʈ��, ������ ���̽� ��, �׻� �轼, ����ī ������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��Ÿ���� ���Ǽҵ�4: ���ο� ���', 1977, '���� ��ī��', '��ũ �ع�, �ظ��� ����, ĳ�� �Ǽ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��Ÿ���� ���Ǽҵ�5: ������ ����', 1980, '���� ��ī��', '��ũ �ع�, �ظ��� ����, ĳ�� �Ǽ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��Ÿ���� ���Ǽҵ�6: �������� ��ȯ', 1983, '���� ��ī��', '��ũ �ع�, �ظ��� ����, ĳ�� �Ǽ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��', 2020, '�̳��� ��ĭƼ', '��� ����, Ű���� �ٷ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�׳�', 2020, 'ũ�������� ���', '�� ���̺�� ������, �ι�Ʈ ��ƾ��, �����ں��� ����Ű, �ɳ׽� �귡��', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��Ǫ���� ��� ���� ���µ�', 2018, '�����', '������, ���켺, �輺��, ������, ������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�κ�������', 2020, '�� ����', '�����ں��� ��, �ø��� �轼-����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��������', 2019, 'Ÿ��ī ����ƼƼ', '�θ� �׸��� ���̺�, �丶�� ��ĵ��, ��Į�� ���ѽ�, Ÿ��ī ����ƼƼ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� V ���', 2019, '���ӽ� �ǰ��', 'ũ������ ����, �� ���̸�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̺꽺 �ƿ�', 2019, '���̾� ����', '�Ƴ� �� �Ƹ�����, �ٴϿ� ũ���̱�, ũ���� ���ݽ�, ����Ŭ ����, ���̹� �� ĿƼ��, ��� �ݷ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� �ƾ���', 2019, '�׷�Ÿ ����', '�þ�� �γ�, ���� �ӽ�, �÷η��� ǻ, Ƽ��� ����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ �����', 2019, '���ȣ', '�̺���, ������, �̼���, ������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ֵ� �ƽ�Ʈ��', 2019, '���ӽ� �׷���', '�귡�� ��Ʈ, ��� �� ����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̿� ŷ', 1994, '���� �˷���, �� ������', '��Ʃ ��ε���, ���ӽ� �� ����, ������ ���̾�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�����̴���: �� ���� Ȩ', 2019, '�� ����', '�� Ȧ����, ����ũ ������, �繫�� L. �轼', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ���丮4', 2019, '���� ��', '�� ��ũ��, �� �˷�, �ִ� ����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ��Ʈ', 2015, '�ƴ� ������', 'ũ������ ����, ��Ƽ�� ī��, ���̾� ������, �귡�� ��Ʈ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�̼ͳ�', 2018, '������', '�迹��, �ڼ���, ������, �����, ������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ��Ƽ', 2018, '����Ÿ�� ����', '�߰� �������׷�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�׸� ��', 2018, '���� �з���', '��� ���ٽ�, ������ �˸�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�', 2019, '���� ��', '����Ÿ �Ͽ˰�, ������ ��ũ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ���̹���: ������ ����', 2018, '�丣���� ��Ƽ��', '���� ����, �ø���� �ݸ�, ����ÿ ������, ���ݶ� ȦƮ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�����', 2019, '������', '������, ������, ������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 1998, 'ũ�������� ���', '������ �����ߵ�, �� ���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ŷ�� ���� ���', 2005, '���鸮 ����', '�ö��� ����, ���� �׸�, ���� �Ͻ�, ������ ���̾�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ҷ���', 2018, '���̺� ���� �׸�', '���̹� �� ĿƼ��, �ֵ� �׸���, ���۽� Ȧ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�۽�Ʈ ��', 2018, '���̾� ����', '���̾� ������, Ŭ���� ����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ϼ�����', 2018, '���±�', '������, ������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��ġ', 2018, '�̳��� ��ĭƼ', '�� ��, ����� �޽�, �̼� ��', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���׷��̵�', 2018, '�� ����', '�ΰ� �����׸�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������', 1958, '�������� ��ġ��', '���ӽ� ��Ʃ��Ʈ, Ŵ ���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ҽý�Ʈ', 1973, '������ ������Ų', '���̽� �з�, ���� ������, ���� ����ƾ, ���� �� �õ���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�Ϻϼ��� ���θ� ������', 1959, '�������� ��ġ��', 'ĳ�� �׷�Ʈ, ���� ���� ����Ʈ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��� ���Ͼ', 2017, '��Ÿ��Ʈ ���Ǹ���', '��Ƽ�� �߿����ο���Ű��, ���� ��Ƽ������, ���̻� ȣ����, Ƽ�� �������ɿ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����', 2018, '������', 'Ȳ����, �̼���, ������, ������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�̼� ���ļ���: ���ƿ�', 2018, 'ũ�������� ������', '�� ũ����, � ī��, ���̸� ���, �� ���ӽ�, ������ �ټ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���', 1972, '�����ý� ���� ������', '���� �����, �� ��ġ��, ���ӽ� ĭ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̾�Ʈ �÷��̽�', 2018, '�� ũ��Ž�Ű', '���и� ����Ʈ, �� ũ��Ž�Ű, ��� ����, �и���Ʈ �ø���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� �÷��̾� ��', 2018, '��Ƽ�� ���ʹ���', 'Ÿ�� �θ���, �ø���� ��, �� �൨��, ���̸� ���, ��ũ ���̷���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ����, ������ �ʿ� ������', 2016, '��Ű Ÿī����', '������ ��Ÿ, ������ ����, �����õ� ��������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ǽ� �Ϸ���', 2001, '��Ƽ�� �Ҵ�����', '���� Ŭ���, �극�� ��Ʈ, �� ġ��, �� ���̸�, �ص� �����þ�, ���̽� ���÷�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ����', 2017, '���Ϸ� ������', '������ ����, �����ں��� �ý�, �� ��Ż', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�丣: ��׳���ũ', 2017, 'Ÿ��ī ����ƼƼ', 'ũ���� �ܽ�����, �� ���齺��, �׻� �轼, ����Ʈ ������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�����̵� ���� 2049', 2017, '��� ������', '���̾� ������, �ظ��� ����, �Ƴ� �� �Ƹ�����, �ڷ��� ����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ѻ꼺', 2017, 'Ȳ����', '�̺���, ������, ������, ����, �����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̺� ����̹�', 2017, '���尡 ����Ʈ', '�ȼ� ����Ʈ, ���� ���ӽ�, �� ��, ���̹� ����, ���̻� ��췹��, �ɺ� �����̽�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����� ���е�', 2017, '���̺� ����ġ', '�������� �׷�, ���ӽ� �ƾ��, ���Ǿ� ���ڶ�, �� �¸�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ɸ�ũ', 2017, 'ũ�������� ���', '�� ȭ��Ʈ���, ��ũ ���̷���, �� �ϵ�, �ظ� ��Ÿ�Ͻ�, �ɳ׽� �귡��', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�����̴���: ȨĿ��', 2017, '�� ����', '�� Ȧ����, ����Ŭ Űư, �ι�Ʈ �ٿ�� �ִϾ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�̺�Ʈ ȣ������', 1997, '�� W.S. �ش���', '�η��� �ǽ���, �� ��, ĳ���� ����, ��ó�� T. ����, ������ ��ó�彼', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� �ƿ�', 2017, '���� ��', '�ٴϿ� Į���, �ٸ��� ��������, �귡�鸮 ������, ĳ���� Ű��', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���Ѵ�: ���� ����� ����', 2016, '������', '�Ȱ汸, �ӽ�ȯ, �����, ������, �̰濵', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̸���: Ŀ����Ʈ', 2017, '���鸮 ����', '����Ŭ �н�����, ĳ���� ���ͽ���, ���� ũ���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ϼ��� �����ϴ� ��ġ����Ŀ�� ���� �ȳ���', 2005, '���� ���׽�', '��ƾ ������, �� ����, �� ����, ���� �����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '23 ���̵�ƼƼ', 2016, 'M. ����Ʈ ������', '���ӽ� �ƾ��, �Ⱦ� ���Ϸ� ����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ΰ�', 2017, '���ӽ� �ǰ��', '�� ���, ������ Ų, ��Ʈ�� ��Ʃ��Ʈ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ��', 2014, '���̺� ����ġ, ä�� ��Ÿ�ｺŰ', 'Ű�ƴ� ���꽺, ���� ����, ���� �˷�, ��ī�� ��ũ��Ʈ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ��2: ���ε�', 2017, 'ä�� ��Ÿ�ｺŰ', 'Ű�ƴ� ���꽺, ��� ����, �̾� �ƽ���, �η��� �ǽ���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� �̸���', 2016, '��ī�� ������', 'ī��Ű ���뽺��, ī�̽ö��̽� ���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̶�', 2001, '���ؼ�', '�ֹν�, �����, �պ�ȣ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ִ�', 2016, '������', '�̻���, ���ƺ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ŷ', 2017, '���縲', '���μ�, ���켺, �輺��, ���ؿ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���̵�ƼƼ', 2003, '���ӽ� �ǰ��', '�� ����, ���� �̷�Ÿ, �Ƹ���  ��Ʈ, �� C. �Ʊ丮, Ŭ���� ���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'Ŭ�ι��ʵ� 10����', 2016, '�� Ʈ��þ����', '�޸� �����ں��� ����Ƽ��, �� �¸�, �� ������ �ִϾ�, �귡�鸮 ����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�α� ��: ��Ÿ���� ���丮', 2016, '���� �������', '�縮��Ƽ ����, �𿡰� �糪, �˶� Ʃ��, ���ڴ�, ����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�ź��� ��������', 2016, '���̺� ������', '���� �������, ĳ���� ���ͽ���, �ݸ� �ķ�, �ٸ��� ����, �� ���۷�, ����� �з�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� �� �� ��ũ', 2016, '�䵥���� �˹ٷ���', '���� ����, ���� �̳�, ��Ƽ�� ��, �ٴϿ� ������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� ��Ʈ������', 2016, '���� ������', '���׵�Ʈ �Ĺ���ġ, ƿ�� ����ư, ����ÿ �ƾƴ㽺, ���� ���̽�, ġ���� ��������, ���׵�Ʈ ��', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�Ƽ���', 2016, '�輺��', '���켺, Ȳ����, ������, ������, ������', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '��ȣ���', 2000, '�̾�', '������, ���ڰ�, ������, ��þ', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, 'ī��', 2013, '�� �Ͽ︵, ����� ����', '�ص� �δ�����', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���ͽ�: õ���� ���� ��', 2008, '�Ľ�Į ������', '���ڳ� �Ƴ���, �з��� ���ĳ���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�λ���', 2016, '����ȣ', '����, ������, ������, �����, ���Ǽ�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�������', 2012, 'ȣ�Ҵ� �����', '�̾���Ű �ƿ���, ����� Ÿī��, ����Ű �Ϸ�, �Ͻ��� ��Ű��, ���� ���ī', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '���� �ҳ�ô�', 2015, '����Ű þ', '�ۿ�ȭ, �մ��', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�����Ǿ�', 2016, '���̷� �Ͽ���, ��ġ ����', '������ ����, ���̽� ����Ʈ��', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '�� ����', 2014, '���̺� ��Ų', '�ι�Ʈ �ٿ�� �ִϾ�, �ι�Ʈ ���, ���� �Ĺ̰�', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '������ �籸��', 2004, '�ֵ���', '�ڽž�, ������, ������, �̹���', '�ڡڡڡ�');
INSERT INTO MOVIE VALUES (MOVIE_SEQ.NEXTVAL, '����Ʈ ũ�ѷ�', 2014, '�� �����', '����ũ ������, ���� ���, ���� �Ƹ޵�', '�ڡڡڡ�');