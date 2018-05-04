Create Database ResturantDB;
use ResturantDB;
Create Schema Resturant

Create Table Resturant.Resturant
(
	rs_id int not null IDENTITY(1,1),
	Name varchar(50),
	Address varchar(50),
	City varchar(50),
	State varchar(2),
	FoodType varchar(20)
);

Create Table Resturant.Review
(	
	rs_id int not null,
	Author varchar(20) not null,
	Rating int not null,
	Comment varchar(300) not null
);
ALTER TABLE Resturant.Resturant
   ADD CONSTRAINT PK_rsid
   Primary KEY (rs_id)

ALTER TABLE Resturant.Review
   ADD CONSTRAINT FK_Cascade
   FOREIGN KEY (rs_id) 
   REFERENCES Resturant.Resturant(rs_id) 
   ON DELETE CASCADE

ALTER TABLE Resturant.Review
   ADD CONSTRAINT PK_Review
   Primary KEY (rs_id,author,rating,comment)


insert into Resturant.Resturant values ('Chil''s','3823 N. Florida St.','Tampa','FL','American')
insert into Resturant.Resturant values ('Apple Bees','9812 Flechter Ave','Tampa','FL','American')
insert into Resturant.Resturant values ('Bon Appetit','323 N 22nd St.','Miami','FL','French')
insert into Resturant.Resturant values ('Joe Crab Shack','9113 Pacific Coast Hwy.','Newport Beach','CA','Seafood')
insert into Resturant.Resturant values ('Magiano''s','3823 N. Florida St.','Tampa','FL','Italian')
insert into Resturant.Resturant values ('Gino''s','314 N. Central Ave','New York','NY','Italian')

insert into Resturant.Resturant ([rs_id], [Name],[Address],[City],[State],[FoodType]) values (7,'The Wok','6021 Highland St.','Tampa','FL','Thai')

Drop Table Resturant.Review

Create Table Resturant.Review
(	
	rv_id int not null IDENTITY(1,1),
	rs_id int not null,
	Author varchar(20) not null,
	Rating int not null,
	Comment varchar(300) not null
);


ALTER TABLE Resturant.Review
   ADD CONSTRAINT FK_Cascade
   FOREIGN KEY (rs_id) 
   REFERENCES Resturant.Resturant(rs_id) 
   ON DELETE CASCADE

ALTER TABLE Resturant.Review
   ADD CONSTRAINT PK_Review
   Primary KEY (rv_id,rs_id,author,rating,comment)

insert into Resturant.Review values(1,'Amy',4,'Good food, but a little greasy. Fast service!')
insert into Resturant.Review values(1,'Jan',1,'Was cold, and over cooked. I didn''t know that was possible!')
insert into Resturant.Review values(1,'Mike',3,'Marginal food but i was late So.... Okay service!')
insert into Resturant.Review values(2,'Chris',1,'These people go way to fair trying create an atomisphere that they forgot my oder!')
insert into Resturant.Review values(2,'Josh',5,'Good food, Great Price. Fast service!')
insert into Resturant.Review values(2,'Carlos',4,'Good food, Drinks expensive though. Service could have been better')
insert into Resturant.Review values(3,'Tamera',2,'Food was bland and dry. Rude service! He stole our baguette!')
insert into Resturant.Review values(3,'Kelly',2,'Food wasn''t that bad, it was the server. What a jerk.')
insert into Resturant.Review values(3,'Dave',3,'Had a baguette while I waited for the bathroom.  Not Bad')
insert into Resturant.Review values(4,'Curt',1,'Thank God this place is right accross the street from a hospital. I had no idea I was allergic')
insert into Resturant.Review values(4,'Rob',2,'Picked up a to-go order.  Leaked all over my car on the way home! It Still SMELLS')
insert into Resturant.Review values(4,'Marcus',1,' I swear they served us the barnicals scrapped off the boats in harbor! Atleast that''s what it tasted like')
insert into Resturant.Review values(5,'Meridith',4,'Good food, Tacky table covers')
insert into Resturant.Review values(5,'Anna',3,'It was fine. About average')
insert into Resturant.Review values(5,'Lisha',3,'Good food but it was late So.... Okay service!')
insert into Resturant.Review values(6,'Jacob',5,'Ginoooooooooossssssss!!!!!!!!!!')
insert into Resturant.Review values(6,'Brad',5,'SSSSSOOOOO GGGGOOOOOOODDDDD!')
insert into Resturant.Review values(6,'Carlos',5,'Whhy did you close? *gasp* wwwwhhhhhhhhyyyyyyy?')
Insert into Resturant.Review values(7,'Chris',1,'I ordered food, but I got this bowl of liquid with vegi...vegitable? Vegetables? Oh God, the horror.')
insert into Resturant.Review values(7,'Danica',5,'Good food, fast service.')
insert into Resturant.Review values(7,'Carla',4,'BBQ Chicken was great')

update Resturant.Resturant 
set [Name] = 'Chili''s'
where rs_id = 1

select * from Resturant.Resturant;
