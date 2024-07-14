SELECT * FROM employee

SELECT * FROM employee WHERE delete_date IS NULL

SELECT * FROM users;

DELETE FROM employee


CREATE TABLE employee (
    id INT PRIMARY KEY IDENTITY(1,1),
    employee_id INT NULL,
    full_name VARCHAR(MAX) NULL,
    gender VARCHAR(MAX) NULL,
    contact_number VARCHAR(MAX) NULL,
    position VARCHAR(MAX) NULL,
    image VARCHAR(MAX) NOT NULL,
    salary INT,
    insert_date DATE NULL,
    update_date DATE NULL,
    delete_date DATE NULL,
    status VARCHAR(MAX) NULL
);
