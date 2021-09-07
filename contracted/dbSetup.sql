CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS contractors(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR(255) COMMENT 'Contractor Name',
  age INT COMMENT 'Contractor Age',
  isMale TINYINT COMMENT 'Gender Male?',
  skillSet VARCHAR(255) COMMENT 'Skill Set'
);
CREATE TABLE IF NOT EXISTS jobs(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'primary key',
  contractorId INT COMMENT 'Contractor Id',
  companyId INT NOT NULL COMMENT 'Company Id',
  FOREIGN KEY (contractorId) REFERENCES contractors(id),
  FOREIGN KEY (companyId) REFERENCES companys(id) ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS companys(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'primary key',
  name VARCHAR(255) NOT NULL COMMENT 'Company Name',
  employeeSize INT COMMENT 'Company Employee Count',
  netWorth INT COMMENT 'Company $ Net Worth'
);
