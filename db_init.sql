use buy_buy_buy
go

drop table order_detail
go
drop table item_info
go
drop table order_info
go
drop table consumer_info
go
drop table pay_info
go

create table consumer_info(
	consumer_id int identity(1,1) primary key,
	consumer_name varchar(60) not null,
)
go

create table pay_info(
	pay_id int identity(1,1) primary key,
	pay_name varchar(60),
)
go

create table order_info(
	order_id int identity(1,1) primary key,
	consumer_id int not null,
	staff varchar(60) not null,
	amount int,
	order_time datetime not null,
	pay_id int not null,
	foreign key (consumer_id) references consumer_info(consumer_id),
	foreign key (pay_id) references pay_info(pay_id),
)
go

create table item_info(
	item_id int identity(1,1) primary key,
	item_name varchar(60) not null,
	item_stock int not null,
)
go

create table order_detail(
	detail_id int identity(1,1) primary key,
	order_id int not null,
	item_id int not null,
	item_quantity int not null,
	foreign key (order_id) references order_info(order_id),
	foreign key (item_id) references item_info(item_id),
)
go
