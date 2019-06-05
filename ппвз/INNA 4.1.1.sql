use var4sql
select CARD_NUM, NAME, SURNAME, AGE, SEX
from PATIENT
where age > 13 and age < 18

SELECT COUNT(*) AS KOLVO, BED_DAYS, AGE
FROM PATIENT
WHERE age = 14 OR age = 15 OR age = 16 OR age = 17
GROUP BY BED_DAYS, AGE

SELECT PATIENT.SURNAME, PATIENT.NAME, PATIENT.AGE, PATIENT.SEX, PATIENT.DISCHARGE, PATIENT.BED_DAYS, treatment.result_name
FROM PATIENT, treatment
WHERE AGE > 18 and treatment_kod = 1
--INNA 4.1.1

select *
from treatment
