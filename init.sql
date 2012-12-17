SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `novav8` ;
CREATE SCHEMA IF NOT EXISTS `novav8` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `novav8` ;

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
  `begin` VARCHAR(30) NULL ,
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
  `date` VARCHAR(30) NOT NULL ,
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

-- -----------------------------------------------------
-- Data for table `novav8`.`Customer`
-- -----------------------------------------------------
START TRANSACTION;
USE `novav8`;
INSERT INTO `novav8`.`Customer` (`id`, `name`, `description`) VALUES (NULL, 'Post', 'Das ist unser Lehrbetrieb');
INSERT INTO `novav8`.`Customer` (`id`, `name`, `description`) VALUES (NULL, 'Denner', 'Ein Discounter');
INSERT INTO `novav8`.`Customer` (`id`, `name`, `description`) VALUES (NULL, 'Migros', 'Ein Grossverteiler, welcher keinen Alkohol verkauft');
INSERT INTO `novav8`.`Customer` (`id`, `name`, `description`) VALUES (NULL, 'Coop', 'Ein Grossverteiler, welcher sehr viel Alkohol verkauft');
INSERT INTO `novav8`.`Customer` (`id`, `name`, `description`) VALUES (NULL, 'Polyconsults', 'Eine Firma, die für die Post Werbung produziert und uns bei der IDPA mit Interviewergebnissen zur seite steht.');

COMMIT;

-- -----------------------------------------------------
-- Data for table `novav8`.`Project`
-- -----------------------------------------------------
START TRANSACTION;
USE `novav8`;
INSERT INTO `novav8`.`Project` (`id`, `number`, `name`, `customer`, `begin`, `active`) VALUES (NULL, '1000', 'Neues Postlogo', 1, '2013-03-12', 1);
INSERT INTO `novav8`.`Project` (`id`, `number`, `name`, `customer`, `begin`, `active`) VALUES (NULL, '2000', 'Nepressokapseln nachahmen', 2, '2013-04-12', 1);
INSERT INTO `novav8`.`Project` (`id`, `number`, `name`, `customer`, `begin`, `active`) VALUES (NULL, '3000', 'Neues Huhn für BIO Werbung', 3, '2013-05-12', 0);
INSERT INTO `novav8`.`Project` (`id`, `number`, `name`, `customer`, `begin`, `active`) VALUES (NULL, '4000', 'Neues Cooplogo für Filiale in Bangladesh', 4, '2013-06-12', 0);
INSERT INTO `novav8`.`Project` (`id`, `number`, `name`, `customer`, `begin`, `active`) VALUES (NULL, '5000', 'Fusion mit Post', 5, '2013-07-12', 1);
INSERT INTO `novav8`.`Project` (`id`, `number`, `name`, `customer`, `begin`, `active`) VALUES (NULL, NULL, NULL, NULL, '', NULL);

COMMIT;

-- -----------------------------------------------------
-- Data for table `novav8`.`Task`
-- -----------------------------------------------------
START TRANSACTION;
USE `novav8`;
INSERT INTO `novav8`.`Task` (`id`, `name`, `description`) VALUES (NULL, 'Unittests', 'Einzelne Komponenten testen');
INSERT INTO `novav8`.`Task` (`id`, `name`, `description`) VALUES (NULL, 'Systemtest', 'Das ganze System testen');
INSERT INTO `novav8`.`Task` (`id`, `name`, `description`) VALUES (NULL, 'Abnahmetest', 'Das System vom Kunden abnehmen lassen');
INSERT INTO `novav8`.`Task` (`id`, `name`, `description`) VALUES (NULL, 'Refactoring', 'Gesamtumbau einer Komponente');
INSERT INTO `novav8`.`Task` (`id`, `name`, `description`) VALUES (NULL, 'Reparieren', 'Reparieren von Komponeten');

COMMIT;

-- -----------------------------------------------------
-- Data for table `novav8`.`Profile`
-- -----------------------------------------------------
START TRANSACTION;
USE `novav8`;
INSERT INTO `novav8`.`Profile` (`id`, `name`) VALUES (NULL, 'moderator');
INSERT INTO `novav8`.`Profile` (`id`, `name`) VALUES (NULL, 'administrator');

COMMIT;

-- -----------------------------------------------------
-- Data for table `novav8`.`User`
-- -----------------------------------------------------
START TRANSACTION;
USE `novav8`;
INSERT INTO `novav8`.`User` (`id`, `name`, `password`, `profile`) VALUES (NULL, 'weberlu', '6c987674d2539afd131abd250da533d9', 1);
INSERT INTO `novav8`.`User` (`id`, `name`, `password`, `profile`) VALUES (NULL, 'philipsn', '6c987674d2539afd131abd250da533d9', 1);
INSERT INTO `novav8`.`User` (`id`, `name`, `password`, `profile`) VALUES (NULL, 'bierik', '6c987674d2539afd131abd250da533d9', 2);
INSERT INTO `novav8`.`User` (`id`, `name`, `password`, `profile`) VALUES (NULL, 'wermerma', '6c987674d2539afd131abd250da533d9', 2);
INSERT INTO `novav8`.`User` (`id`, `name`, `password`, `profile`) VALUES (NULL, 'herrena', '6c987674d2539afd131abd250da533d9', 1);

COMMIT;

-- -----------------------------------------------------
-- Data for table `novav8`.`Report`
-- -----------------------------------------------------
START TRANSACTION;
USE `novav8`;
INSERT INTO `novav8`.`Report` (`id`, `date`, `task`, `description`, `project`, `expenditure`, `user`) VALUES (NULL, '2012-02-12', 1, 'Ich habe das gemacht', 1, 30, 1);
INSERT INTO `novav8`.`Report` (`id`, `date`, `task`, `description`, `project`, `expenditure`, `user`) VALUES (NULL, '2012-03-12', 2, 'Ich habe das gemacht', 2, 37, 2);
INSERT INTO `novav8`.`Report` (`id`, `date`, `task`, `description`, `project`, `expenditure`, `user`) VALUES (NULL, '2012-04-12', 3, 'Ich habe das gemacht', 3, 765, 3);
INSERT INTO `novav8`.`Report` (`id`, `date`, `task`, `description`, `project`, `expenditure`, `user`) VALUES (NULL, '2012-05-12', 4, 'Ich habe das gemacht', 4, 45, 4);
INSERT INTO `novav8`.`Report` (`id`, `date`, `task`, `description`, `project`, `expenditure`, `user`) VALUES (NULL, '2012-06-12', 5, 'Ich habe das gemacht', 5, 97, 5);
INSERT INTO `novav8`.`Report` (`id`, `date`, `task`, `description`, `project`, `expenditure`, `user`) VALUES (NULL, NULL, NULL, NULL, NULL, , NULL);

COMMIT;

-- -----------------------------------------------------
-- Data for table `novav8`.`Component`
-- -----------------------------------------------------
START TRANSACTION;
USE `novav8`;
INSERT INTO `novav8`.`Component` (`id`, `name`) VALUES (NULL, 'Benutzer hinzufügen');
INSERT INTO `novav8`.`Component` (`id`, `name`) VALUES (NULL, 'Benutzer bearbeiten');
INSERT INTO `novav8`.`Component` (`id`, `name`) VALUES (NULL, 'Rapport hinzufügen');
INSERT INTO `novav8`.`Component` (`id`, `name`) VALUES (NULL, 'Rapport bearbeiten');
INSERT INTO `novav8`.`Component` (`id`, `name`) VALUES (NULL, 'Kunde hinzufügen');
INSERT INTO `novav8`.`Component` (`id`, `name`) VALUES (NULL, 'Kunde bearbeiten');
INSERT INTO `novav8`.`Component` (`id`, `name`) VALUES (NULL, 'Task hinzufügen');
INSERT INTO `novav8`.`Component` (`id`, `name`) VALUES (NULL, 'Task bearbeiten');

COMMIT;

-- -----------------------------------------------------
-- Data for table `novav8`.`Permission`
-- -----------------------------------------------------
START TRANSACTION;
USE `novav8`;
INSERT INTO `novav8`.`Permission` (`id`, `component`, `profile`) VALUES (NULL, 1, 1);
INSERT INTO `novav8`.`Permission` (`id`, `component`, `profile`) VALUES (NULL, 2, 1);
INSERT INTO `novav8`.`Permission` (`id`, `component`, `profile`) VALUES (NULL, 3, 1);
INSERT INTO `novav8`.`Permission` (`id`, `component`, `profile`) VALUES (NULL, 4, 1);
INSERT INTO `novav8`.`Permission` (`id`, `component`, `profile`) VALUES (NULL, 5, 2);
INSERT INTO `novav8`.`Permission` (`id`, `component`, `profile`) VALUES (NULL, 6, 2);
INSERT INTO `novav8`.`Permission` (`id`, `component`, `profile`) VALUES (NULL, 7, 2);
INSERT INTO `novav8`.`Permission` (`id`, `component`, `profile`) VALUES (NULL, 8, 2);

COMMIT;
