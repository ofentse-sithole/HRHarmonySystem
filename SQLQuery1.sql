CREATE TABLE employee(
	id INT PRIMARY KEY IDENTITY(1,1),
	employee_id INT NULL,
	full_name VARCHAR(MAX) NULL,
	gender VARCHAR(MAX) NULL,
	contact_number VARCHAR(MAX) NULL,
	position VARCHAR(MAX) NULL,
	image VARCHAR(MAX) NOT NULL,
	salary FLOAT,
	insert_date DATE NULL,
	update_date DATE NULL,
	delete_date DATE NULL,
)

SELECT * from employee

ALTER TABLE employee
ADD  status VARCHAR(MAX) NULL 