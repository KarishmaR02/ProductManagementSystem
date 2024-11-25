/*ADMIN TABLE*/
create table admin(admin_id int primary key, username varchar(30) not null,password varchar(30) not null,email varchar(30) not null,
	full_name varchar(30) not null,phone_number bigint not null,address varchar(100),created_at date default getdate(),status varchar(20) default 'active')
 /*PRODUCT TABLE*/
 create table product_basic_info(product_id int primary key,product_name varchar(50) not null,description varchar(200),
	category varchar(100),price bigint not null,stock_quantity int not null,manufacturer varchar(50),
	release_date date,create_at date default getdate(),update_at date default current_timestamp,status varchar(20) default 'true',additional_info varchar(100))
/*CUSTOMER INFO TABLE*/
create table customer_info(customer_id int primary key,first_name varchar(30) not null,last_name varchar(20) not null,
	email varchar(30) not null,phoneno bigint not null,address varchar(100),city varchar(25) not null,
	country varchar(25) default 'India',registration_date date,last_purchase_date date,total_purchase int default 0,additional_info varchar(30))
/*	INSERT INTO ADMIN*/
insert into admin(admin_id,username,password,email,full_name,phone_number,address)
	values(101,'admin','123','admin@gmail.com','administration',6374458915,'11th cross,Thillainagar')
/**/

alter table customer_info add username varchar(30),password varchar(30)
sp_help customer_info
select * from customer_info
update customer_info set username='karishma',password=123 where customer_id=1