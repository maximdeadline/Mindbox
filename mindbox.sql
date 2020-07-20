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
('������� 1'),
('������� 2'),
('������� 3'),
('������� 4'),
('������� 5'),
('������� 6'),
('������� 7')

insert into category values
('��������� 1'),
('��������� 2'),
('��������� 3'),
('��������� 4'),
('��������� 5'),
('��������� 6')

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

select case when P.name is NULL then '��� ���������' else P.name end '��������',
case when C.name is NULL then '��� ���������' else C.name end '���������' 
from product_category as PC 
right join product as P on PC.product_id = P.ID 
full join category as C on PC.category_id = C.ID