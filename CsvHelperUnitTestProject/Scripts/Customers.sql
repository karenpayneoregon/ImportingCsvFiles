
-- Office
DECLARE @PhoneType AS INT= 3;

-- Owner
DECLARE @ContactType AS INT= 7;

SELECT C.CustomerIdentifier,
    C.CompanyName,
    C.City,
    C.PostalCode,
    Contacts.ContactId,
    Countries.CountryIdentifier,
    C.Phone 
FROM Customers AS C
    INNER JOIN ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier
    INNER JOIN Countries ON C.CountryIdentifier = Countries.CountryIdentifier
    INNER JOIN Contacts ON C.ContactId = Contacts.ContactId
    INNER JOIN ContactDevices AS Devices ON Contacts.ContactId = Devices.ContactId
WHERE Devices.PhoneTypeIdentifier = @PhoneType
    AND C.ContactTypeIdentifier = @ContactType;
