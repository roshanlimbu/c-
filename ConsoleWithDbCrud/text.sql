Create database TestDb;
use TestDb;
create table Student{
  id int primary key,
  [Name] nvarchar (50) not null,
  [Address] nvarchar (40 ) null,
  DoB date not null default(getdate()),
  Gender bit not null default (0)
};
