CREATE PROCEDURE [dbo].[p_GetStudent]
    @studentId INT = NULL,
    @login VARCHAR(50) = NULL,
    @smarsyChildId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF (COALESCE(@studentId, @login, @smarsyChildId) IS NULL)
    BEGIN
        THROW 50000, 'No parameters are set', 1;
    END;

    SELECT s.Id,
        s.Name,
        s.Login,
        s.Password,
        s.SmarsyChildId,
        s.BirthDate
    FROM dbo.Student AS s
    WHERE
    (
        s.Login = @login
        OR @login IS NULL
    )
    AND
    (
        s.Id = @studentId
        OR @studentId IS NULL
    )
    AND
    (
        s.SmarsyChildId = @smarsyChildId
        OR @smarsyChildId IS NULL
    );

END;