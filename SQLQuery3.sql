SELECT FoodInTheFridge.Name, FoodType.FoodTypeName FROM FoodInTheFridge
JOIN FoodInTheFridge ON FoodInTheFridge.TypeId = FoodType.Id
WHERE FoodInTheFridge.FoodTypeName LIKE 'Dairy'