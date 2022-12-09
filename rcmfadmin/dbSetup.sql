-- Active: 1669834043794@@rcmforg.mysql.database.azure.com@3306@rcmforg

CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(1000) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS players(
        id INT NOT NULL primary key AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255),
        email varchar(255),
        shirtSize varchar(255),
        teamId INT NOT NULL,
        FOREIGN KEY (teamId) REFERENCES teams(id)
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS teams(
        id INT NOT NULL primary key AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255),
        email varchar(255),
        phone INT,
        sponsorId INT,
        tournamentId INT NOT NULL,
        FOREIGN KEY (sponsorId) REFERENCES sponsors(id),
        FOREIGN KEY (tournamentId) REFERENCES tournaments(id)
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS sponsors(
        id INT NOT NULL primary key AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255),
        email varchar(255),
        tier varchar(255)
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS tournaments(
        id INT NOT NULL primary key AUTO_INCREMENT,
        date DATETIME,
        location varchar(255),
        archived BOOLEAN,
        netIncome INT
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS donors(
        id INT NOT NULL primary key AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255),
        email varchar(255),
        amount INT
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS grants(
        id INT NOT NULL primary key AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255),
        email varchar(255),
        description VARCHAR(500),
        department VARCHAR(255),
        budget INT,
        amount INT,
        trainingProvider VARCHAR(255)
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS newsLetters(
        id INT NOT NULL primary key AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255),
        email varchar(255)
    ) default charset utf8 COMMENT '';



