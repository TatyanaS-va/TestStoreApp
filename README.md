В проекте используется PostgreSQL.

Для запуска необходимо в ConnectionString (Папка DataAccess -> Класс ConnectionInfo) указать данные для подключения к БД.

В Package Manager Console написать команду Update-Database.

Для генерации исходных данных можно использовать запросы:
INSERT INTO public."Boxes"(
	  "ProductionDate", "Width", "Height", "Depth", "Weight")
	VALUES (TO_DATE('22-03-2022', 'DD-MM-YYYY'),50,60,70 ,80),
	(TO_DATE('22-03-2024', 'DD-MM-YYYY'),90,100,70 ,50),
	(TO_DATE('21-02-2023', 'DD-MM-YYYY'),50,60,78 ,70),
	(TO_DATE('15-07-2024', 'DD-MM-YYYY'),60,20,70 ,80),
	(TO_DATE('19-04-2023', 'DD-MM-YYYY'),90,60,70 ,80),
	(TO_DATE('10-07-2024', 'DD-MM-YYYY'),50,40,70 ,86),
	(TO_DATE('10-07-2024', 'DD-MM-YYYY'),30,60,80 ,34),
	(TO_DATE('15-07-2024', 'DD-MM-YYYY'),90,30,40 ,50),
	(TO_DATE('22-03-2023', 'DD-MM-YYYY'),30,90,70 ,30),
	(TO_DATE('22-03-2023', 'DD-MM-YYYY'),40,60,70 ,100),
  	(TO_DATE('22-07-2022', 'DD-MM-YYYY'),20,30,60,80),
	(TO_DATE('22-03-2022', 'DD-MM-YYYY'),60,40,60,80),
  	(TO_DATE('22-03-2024', 'DD-MM-YYYY'),50,60,70 ,80),
	(TO_DATE('25-03-2022', 'DD-MM-YYYY'),20,30,60,80),
	(TO_DATE('22-03-2022', 'DD-MM-YYYY'),60,40,60,80)
	;

 INSERT INTO public."Palletes"(
	"Width", "Height", "Depth")
	VALUES (300,100,200),
	(190,90,30),
	(250,100,150),
	(100,56,48),
	(350,560,480),
	(200,100,300),
	(200,300,600),
  	(100,560,480),
	(200,1050,300);

