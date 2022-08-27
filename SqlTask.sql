SELECT P.Name, C.Name
  FROM Product P
    
LEFT JOIN ProductToCategory PC
       ON P.Id = PC.ProductId
LEFT JOIN Category C
       ON PC.CategoryId = C.Id