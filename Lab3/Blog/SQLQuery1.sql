--1
SELECT * FROM Kategoria WHERE NazwaKateogrii = 'Procesory';

--2
Select PostID from Comment
WHERE PostID > 1;

--Distinct unikalne komentarze bez dubli
SELECT DISTINCT POSTID From Comment

--AND OR Posty inne od pierwszego
SELECT * FROM Post
WHERE PostID > 1 AND ShortDescription LIKE('G%');

--LIKE posty których tytuł zawiera głó
Select Title From Post WHERE Body LIKE('%GPU%');

--ORDER BY Sortuj po POSTID
SELECT * FROM Comment
ORDER BY PostID DESC;

--IN gdzie postID zawiera 1 lub 3
SELECT * FROM Comment
where PostID IN(1,3);

--INSERT INTO
INSERT  Kategoria (NazwaKateogrii,OpisKategorii,NazwaPlikuIkony)
VALUES('Nowa','Test','Ikona1');

--UPDATE
UPDATE Kategoria SET NazwaKateogrii = 'JuzNieNowa' Where NazwaKateogrii = 'Nowa';

--DELETE 
DELETE FROM Kategoria
WHERE KategoriaId = 5;

--TOP PIERWSZY Komentars z alfabetycznej listy
SELECT TOP 1  * FROM Comment 
ORDER BY Body;

--inner złącz i pokaż treść komentarza gdzie post jest z kat GPU
SELECT k.Body FROM
Comment k INNER JOIN Post p ON k.PostID = p.PostID
where p.ShortDescription = 'GPU'

--UNION
SELECT NazwaKateogrii FROM Kategoria
union all 
select body FROM Post


--Group by and having długość
SELECT PostID, Body
FROM Comment
GROUP BY PostID, Body
HAVING LEN(Body) > 3;

--Any
SELECT CommentId
FROM Comment
WHERE CommentId = ANY (SELECT CommentId FROM Comment WHERE Zgloszony = 'True');

--NULL
SELECT CommentId FROM Comment
WHERE Body IS NULL;

--Policz komentarze
Select Count(CommentId) from Comment;

--NAJWCZEŚNIEJSZY POST
SELECT * FROM Comment
WHERE DataWstawieniaKomentarza = (SELECT MIN(DataWstawieniaKomentarza) FROM Comment)

--BETWEEN wybierz komentarze które długość komentarza jest pomiędzy 1 a 4
Select * from Comment
WHERE LEN(Body) Between 1 AND 4
