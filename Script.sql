CREATE TABLE Student
(
	Id int IDENTITY(1,1) not null primary key, 
	Name nvarchar(20) not null,
	Surname nvarchar(20) not null,
	Email nvarchar(50) not null,
	IndexNumber nvarchar(50) not null
)
CREATE TABLE Course
(
	Id int IDENTITY(1,1) not null primary key, 
	Name nvarchar(20) not null
)
CREATE TABLE Lecture
(
	Id int IDENTITY(1,1) not null primary key, 
	Name nvarchar(20) not null,
	CourseId int not null foreign key references Course(Id)
)
CREATE TABLE Student_Course
(
	 
	StudentId int not null foreign key references Student(Id), 
	CourseId int not null foreign key references Course(Id),
	Grade nvarchar(50),
	CONSTRAINT [PK_Student_Course] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[CourseId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	