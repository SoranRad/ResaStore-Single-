
UPDATE Anbar.tbl_Amaliat_Title 

SET mablaq = (Riz.RizSum - ISNULL(tad.mablaq_takhfif,0)+ ISNULL(tad.mablaq_Maliat,0)+ ISNULL(tad.Ezafat,0))



SELECT
tat.Serial,
tat.kind,
tat.FK_AshXas_ID,
tat.mablaq,
riz.RizSum,
tad.mablaq_takhfif,
tad.mablaq_Maliat,
tad.Ezafat

FROM Anbar.tbl_Amaliat_Title AS tat
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail  as tad on tad.ID = tat.ID
LEFT OUTER JOIN 
(

    SELECT SUM(tar.mablaq) AS RizSum ,FK_Title
    FROM Anbar.tbl_Amaliat_Riz AS tar
    WHERE FK_Salmali =1404
    GROUP BY FK_Title

) AS Riz ON Riz.FK_Title = tat.ID

WHERE (Riz.RizSum - ISNULL(tad.mablaq_takhfif,0)) <> tat.mablaq AND tat.FK_Salmali = 1404 AND tat.kind = 50

