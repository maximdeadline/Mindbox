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
('ïðîäóêò 1'),
('ïðîäóêò 2'),
('ïðîäóêò 3'),
('ïðîäóêò 4'),
('ïðîäóêò 5'),
('ïðîäóêò 6'),
('ïðîäóêò 7')


insert into category values
('êàòåãîðèÿ 1'),
('êàòåãîðèÿ 2'),
('êàòåãîðèÿ 3'),
('êàòåãîðèÿ 4'),
('êàòåãîðèÿ 5'),
('êàòåãîðèÿ 6')

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

select case when P.name is NULL then 'Íåò ïðîäóêòîâ' else P.name end 'Ïðîäóêòû',
case when C.name is NULL then 'Íåò êàòåãîðèé' else C.name end 'Êàòåãîðèÿ' 
from product_category as PC 
right join product as P on PC.product_id = P.ID 
full join category as C on PC.category_id = C.ID
