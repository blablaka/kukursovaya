use var4sql
select SURNAME, GOTOHOSPITAL, NAME, SEX, AGE, dep_name
from PATIENT, department
where GOTOHOSPITAL >= '20010301' and GOTOHOSPITAL < '20010401'
order by GOTOHOSPITAL

select count (*) as molodoipodrostokvzrosliy, sum(BED_DAYS) as Beddays
from PATIENT
where age < 14
union
select COUNT (*) as podrostok, sum(BED_DAYS) as Beddays
from PATIENT
where age >= 14 and age <=17
union
select count (*) as vzrosliy, sum(BED_DAYS) as Beddays
from PATIENT
where age > 17

select count (*)as bolnoi, avg(age) as age, treatment_kod
from PATIENT, treatment
where age >=1
group by treatment_kod
order by treatment_kod
--INNA 4.1.2
