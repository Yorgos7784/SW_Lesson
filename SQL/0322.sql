DROP TABLE SELLER CASCADE CONSTRAINTS;
CREATE TABLE seller
(
    seller_id INT NOT NULL, 
    name VARCHAR2(20) NOT NULL, 
    tel VARCHAR2(20) NOT NULL, 
    email VARCHAR2(20), 
    grade VARCHAR2(20) NOT NULL, 
    derijum VARCHAR2(20) NOT NULL, 
    CONSTRAINT SELLER_PK PRIMARY KEY (seller_id)
);
DROP SEQUENCE SELLER_SEQ;
CREATE SEQUENCE seller_SEQ START WITH 1 INCREMENT BY 1;

DROP TABLE CUSTOMER CASCADE CONSTRAINTS;
CREATE TABLE customer
(
    cus_id INT NOT NULL, 
    name VARCHAR2(20) NOT NULL, 
    tel VARCHAR2(20) NOT NULL, 
    addr VARCHAR2(20) NOT NULL, 
    email VARCHAR2(20), 
    CONSTRAINT CUSTOMER_PK PRIMARY KEY (cus_id)
);
DROP SEQUENCE CUSTOMER_SEQ;
CREATE SEQUENCE customer_SEQ START WITH 1 INCREMENT BY 1;

DROP TABLE CAR CASCADE CONSTRAINTS;
CREATE TABLE car
(
    car_id INT NOT NULL, 
    model VARCHAR2(20) NOT NULL, 
    color VARCHAR2(20) NOT NULL, 
    company VARCHAR2(20) NOT NULL, 
    price VARCHAR2(20) NOT NULL, 
    year VARCHAR2(20) NOT NULL, 
    CONSTRAINT CAR_PK PRIMARY KEY (car_id)
);
DROP SEQUENCE CAR_SEQ;
CREATE SEQUENCE car_SEQ START WITH 1 INCREMENT BY 1;

DROP TABLE ORDER_TABLE;
CREATE TABLE order_table
(
    order_num INT NOT NULL, 
    order_date VARCHAR2(20) NOT NULL, 
    final_price VARCHAR2(20) NOT NULL, 
    seller_id INT NOT NULL, 
    cus_id INT NOT NULL, 
    car_id INT NOT NULL, 
    CONSTRAINT ORDER_TABLE_PK PRIMARY KEY (order_num),
    CONSTRAINT FK_order_table_seller_id_selle FOREIGN KEY (seller_id) REFERENCES seller (seller_id),
    CONSTRAINT FK_order_table_cus_id_customer FOREIGN KEY (cus_id) REFERENCES customer (cus_id),
    CONSTRAINT FK_order_table_car_id_car_car_ FOREIGN KEY (car_id) REFERENCES car (car_id)
);
DROP SEQUENCE ORDER_TABLE_SEQ;
CREATE SEQUENCE order_table_SEQ START WITH 1 INCREMENT BY 1;
/*ALTER TABLE order_table ADD CONSTRAINT FK_order_table_seller_id_selle FOREIGN KEY (seller_id) REFERENCES seller (seller_id);
ALTER TABLE order_table ADD CONSTRAINT FK_order_table_cus_id_customer FOREIGN KEY (cus_id) REFERENCES customer (cus_id);
ALTER TABLE order_table ADD CONSTRAINT FK_order_table_car_id_car_car_ FOREIGN KEY (car_id) REFERENCES car (car_id);*/