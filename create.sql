SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';


-- -----------------------------------------------------
-- Table `novav8`.`Customer`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `novav8`.`Customer` ;

CREATE  TABLE IF NOT EXISTS `novav8`.`Customer` (
  `id` INT(10) NOT NULL AUTO_INCREMENT ,
  `name` VARCHAR(200) CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NOT NULL ,
  `description` TEXT NULL ,
  PRIMARY KEY (`id`) ,
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `novav8`.`Project`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `novav8`.`Project` ;

CREATE  TABLE IF NOT EXISTS `novav8`.`Project` (
  `id` INT(10) NOT NULL AUTO_INCREMENT ,
  `number` VARCHAR(12) CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NOT NULL ,
  `name` VARCHAR(200) NOT NULL ,
  `customer` INT(10) NULL ,
  `begin` DATE NULL ,
  `active` TINYINT(1) NOT NULL ,
  PRIMARY KEY (`id`) ,
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) ,
  UNIQUE INDEX `nummer_UNIQUE` (`number` ASC) ,
  INDEX `projekt_kunde_idx` (`customer` ASC) ,
  CONSTRAINT `projekt_kunde`
    FOREIGN KEY (`customer` )
    REFERENCES `novav8`.`Customer` (`id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;


-- -----------------------------------------------------
-- Table `novav8`.`Task`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `novav8`.`Task` ;

CREATE  TABLE IF NOT EXISTS `novav8`.`Task` (
  `id` INT(10) NOT NULL AUTO_INCREMENT ,
  `name` VARCHAR(200) NOT NULL ,
  `description` TEXT NULL ,
  PRIMARY KEY (`id`) ,
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;


-- -----------------------------------------------------
-- Table `novav8`.`Profile`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `novav8`.`Profile` ;

CREATE  TABLE IF NOT EXISTS `novav8`.`Profile` (
  `id` INT(10) NOT NULL AUTO_INCREMENT ,
  `name` VARCHAR(200) NOT NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;


-- -----------------------------------------------------
-- Table `novav8`.`User`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `novav8`.`User` ;

CREATE  TABLE IF NOT EXISTS `novav8`.`User` (
  `id` INT(10) NOT NULL AUTO_INCREMENT ,
  `name` VARCHAR(200) CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NOT NULL ,
  `password` VARCHAR(32) NOT NULL ,
  `profile` INT(10) NULL ,
  PRIMARY KEY (`id`) ,
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) ,
  UNIQUE INDEX `name_UNIQUE` (`name` ASC) ,
  INDEX `benutzer_profil_idx` (`profile` ASC) ,
  CONSTRAINT `benutzer_profil`
    FOREIGN KEY (`profile` )
    REFERENCES `novav8`.`Profile` (`id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;


-- -----------------------------------------------------
-- Table `novav8`.`Report`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `novav8`.`Report` ;

CREATE  TABLE IF NOT EXISTS `novav8`.`Report` (
  `id` INT(10) NOT NULL AUTO_INCREMENT ,
  `date` DATE NOT NULL ,
  `task` INT(10) NOT NULL ,
  `description` VARCHAR(200) NULL ,
  `project` INT(10) NULL ,
  `expenditure` INT(10) NOT NULL ,
  `user` INT(10) NOT NULL ,
  PRIMARY KEY (`id`) ,
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) ,
  INDEX `rapport_projekt_idx` (`project` ASC) ,
  INDEX `rapport_aufgabe_idx` (`task` ASC) ,
  INDEX `rapport_benutzer_idx` (`user` ASC) ,
  CONSTRAINT `rapport_projekt`
    FOREIGN KEY (`project` )
    REFERENCES `novav8`.`Project` (`id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `rapport_aufgabe`
    FOREIGN KEY (`task` )
    REFERENCES `novav8`.`Task` (`id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `rapport_benutzer`
    FOREIGN KEY (`user` )
    REFERENCES `novav8`.`User` (`id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;


-- -----------------------------------------------------
-- Table `novav8`.`Component`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `novav8`.`Component` ;

CREATE  TABLE IF NOT EXISTS `novav8`.`Component` (
  `id` INT(10) NOT NULL AUTO_INCREMENT ,
  `name` VARCHAR(200) NULL ,
  PRIMARY KEY (`id`) ,
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;


-- -----------------------------------------------------
-- Table `novav8`.`Permission`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `novav8`.`Permission` ;

CREATE  TABLE IF NOT EXISTS `novav8`.`Permission` (
  `id` INT(10) NOT NULL AUTO_INCREMENT ,
  `component` INT(10) NOT NULL ,
  `profile` INT(10) NOT NULL ,
  PRIMARY KEY (`id`) ,
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) ,
  INDEX `berechtigung_komponente_idx` (`component` ASC) ,
  INDEX `berechtigung_profil_idx` (`profile` ASC) ,
  CONSTRAINT `berechtigung_komponente`
    FOREIGN KEY (`component` )
    REFERENCES `novav8`.`Component` (`id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `berechtigung_profil`
    FOREIGN KEY (`profile` )
    REFERENCES `novav8`.`Profile` (`id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;