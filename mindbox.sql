use mindbox

create table product (
ID INT identity(1,1) primary key,
name nvarchar(50)
);

create table category (
ID INT identity(1,1) primary key,
name nvarchar(50)
);

create table product_category (
product_id INT,
category_id INT,
FOREIGN KEY (product_id) REFERENCES product(ID),
FOREIGN KEY (category_id) REFERENCES category(ID)
);

insert into product values
('продукт 1'),
('продукт 2'),
('продукт 3'),
('продукт 4'),
('продукт 5'),
('продукт 6'),
('продукт 7')

insert into category values
('категория 1'),
('категория 2'),
('категория 3'),
('категория 4'),
('категория 5'),
('категория 6')

insert into product_category values
(1,1),
(1,2),
(2,1),
(3,3),
(4,4),
(5,5),
(5,1),
(4,2),
(3,5)

select case when P.name is NULL then 'Нет продуктов' else P.name end 'Продукты',
case when C.name is NULL then 'Нет категорий' else C.name end 'Категория' 
from product_category as PC 
right join product as P on PC.product_id = P.ID 
full join category as C on PC.category_id = C.ID
