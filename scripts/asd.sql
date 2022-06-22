Alter Table Address
Add Id_new Int Identity(1, 1)
Go

Alter Table Address Drop Column Id
Go

Exec sp_rename 'Address.Id_new', 'Id', 'Column'