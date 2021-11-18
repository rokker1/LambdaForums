SELECT * FROM Posts

INSERT INTO Posts (Content, Created, ForumId, Title, Userid)
VALUES ('First Python Post Content Here .............', GETDATE(),	1, 'First Python Post', 'c390b664-4f03-4205-96d3-bdac8608ca34')

INSERT INTO Posts (Content, Created, ForumId, Title, Userid)
VALUES ('Second Python Post... !', GETDATE(), 1, 'Another Python Post', 'c390b664-4f03-4205-96d3-bdac8608ca34'),
('More Python', GETDATE(), 1, 'Python for Machine Learning', 'c390b664-4f03-4205-96d3-bdac8608ca34'),
('More Content', GETDATE(), 1, 'Using Matplotlib', 'c390b664-4f03-4205-96d3-bdac8608ca34');


SELECT * FROM AspNetUsers

SELECT p.Title AS PostName, f.Title AS ForumName , u.Email
FROM Posts p
	INNER JOIN Forums f ON p.ForumId = f.Id
	INNER JOIN AspNetUsers u ON u.Id = p.UserId
WHERE p.Id = 1
