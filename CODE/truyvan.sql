USE STORE
GO

SELECT*
FROM HOADON
WHERE YEAR(NGAYLAP) = '2020'

SELECT COUNT(*) FROM dbo.HOADON

SELECT*
FROM KHACHHANG
WHERE TPHO = 'HCM'

SELECT*
FROM SANPHAM
WHERE GIA < 3000 AND GIA > 500

SELECT*
FROM SANPHAM
WHERE SOLUONGTON < 100

SELECT SANPHAM.TENSP
FROM SANPHAM, CT_HOADON
WHERE SANPHAM.MASP = CT_HOADON.MASP
GROUP BY SANPHAM.MASP , SANPHAM.TENSP
ORDER BY SUM(dbo.CT_HOADON.SOLUONG) DESC

SELECT SANPHAM.TENSP
FROM SANPHAM, CT_HOADON
WHERE SANPHAM.MASP = CT_HOADON.MASP AND CT_HOADON.THANHTIEN = (
	SELECT MAX(CT.THANHTIEN) FROM dbo.CT_HOADON CT)

SELECT *
FROM dbo.CT_HOADON CT,dbo.HOADON HD,dbo.SANPHAM SP
WHERE ct.MAHD = hd.MAHD AND sp.MASP = ct.MASP

SELECT *
FROM dbo.HOADON HD JOIN dbo.CT_HOADON CT ON CT.MAHD = HD.MAHD JOIN dbo.SANPHAM SP ON SP.MASP = CT.MASP

SELECT *
FROM dbo.SANPHAM SP, dbo.CT_HOADON CT
WHERE SP.MASP = CT.MASP

SELECT *
FROM dbo.SANPHAM SP JOIN dbo.CT_HOADON CT ON CT.MASP = SP.MASP



CREATE TRIGGER TRG_THANHTIEN ON CT_HOADON AFTER INSERT AS
BEGIN
	UPDATE CT_HOADON
	SET GIABAN = SANPHAM.GIA
	FROM SANPHAM
	WHERE SANPHAM.MASP = CT_HOADON.MASP
	
	UPDATE CT_HOADON
	SET THANHTIEN = INSERTED.SOLUONG * (CT_HOADON.GIABAN - inserted.GIAGIAM)
	FROM inserted
	WHERE inserted.MASP = CT_HOADON.MASP AND inserted.MAHD = CT_HOADON.MAHD AND CT_HOADON.GIABAN > CT_HOADON.GIAGIAM

	UPDATE HOADON
	SET TONGTIEN = (SELECT SUM(CT_HOADON.THANHTIEN) FROM CT_HOADON WHERE CT_HOADON.THANHTIEN IS NOT NULL AND HOADON.MAHD = CT_HOADON.MAHD )
	FROM CT_HOADON
	WHERE HOADON.MAHD = CT_HOADON.MAHD 
END

SELECT * FROM dbo.HOADON
SELECT * FROM dbo.CT_HOADON