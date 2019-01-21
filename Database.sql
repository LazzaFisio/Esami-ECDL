SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `Esami ECDL` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Esami ECDL` ;

-- -----------------------------------------------------
-- Table `Esami ECDL`.`Esami`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`Esami` (
  `idEsami` INT NOT NULL AUTO_INCREMENT ,
  `tipo` VARCHAR(45) NULL ,
  `percMinima` VARCHAR(45) NULL ,
  PRIMARY KEY (`idEsami`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Esami ECDL`.`Città`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`Città` (
  `idCittà` INT NOT NULL AUTO_INCREMENT ,
  `nome` VARCHAR(45) NULL ,
  `comune` VARCHAR(45) NULL ,
  `provincia` VARCHAR(45) NULL ,
  `regione` VARCHAR(45) NULL ,
  PRIMARY KEY (`idCittà`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Esami ECDL`.`Esaminandi`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`Esaminandi` (
  `codice` INT NOT NULL AUTO_INCREMENT ,
  `nome` VARCHAR(45) NULL ,
  `cognome` VARCHAR(45) NULL ,
  `sesso` VARCHAR(45) NULL ,
  `DataNascita` DATETIME NULL ,
  `idCittà` INT NOT NULL ,
  PRIMARY KEY (`codice`) ,
  INDEX `fk_Esaminandi_Città1_idx` (`idCittà` ASC) ,
  CONSTRAINT `fk_Esaminandi_Città1`
    FOREIGN KEY (`idCittà` )
    REFERENCES `Esami ECDL`.`Città` (`idCittà` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Esami ECDL`.`Sede`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`Sede` (
  `idSede` INT NOT NULL ,
  `nome` VARCHAR(45) NULL ,
  `idCittà` INT NOT NULL ,
  PRIMARY KEY (`idSede`) ,
  INDEX `fk_Sede_Città1_idx` (`idCittà` ASC) ,
  CONSTRAINT `fk_Sede_Città1`
    FOREIGN KEY (`idCittà` )
    REFERENCES `Esami ECDL`.`Città` (`idCittà` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Esami ECDL`.`SkillCard`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`SkillCard` (
  `idSkillCard` INT NOT NULL AUTO_INCREMENT ,
  `DataEmissione` DATETIME NULL ,
  `DataScadenza` DATETIME NULL ,
  `codice` INT NOT NULL ,
  PRIMARY KEY (`idSkillCard`) ,
  INDEX `fk_SkillCard_Esaminandi1_idx` (`codice` ASC) ,
  CONSTRAINT `fk_SkillCard_Esaminandi1`
    FOREIGN KEY (`codice` )
    REFERENCES `Esami ECDL`.`Esaminandi` (`codice` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Esami ECDL`.`Risultato`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`Risultato` (
  `idEsami` INT NOT NULL ,
  `idSkillCard` INT NOT NULL ,
  `esito` VARCHAR(45) NULL ,
  `percentuale` VARCHAR(45) NULL ,
  PRIMARY KEY (`idEsami`, `idSkillCard`) ,
  INDEX `fk_Esaminandi_has_Esami_Esami1_idx` (`idEsami` ASC) ,
  INDEX `fk_Risultato_SkillCard1_idx` (`idSkillCard` ASC) ,
  CONSTRAINT `fk_Esaminandi_has_Esami_Esami1`
    FOREIGN KEY (`idEsami` )
    REFERENCES `Esami ECDL`.`Esami` (`idEsami` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Risultato_SkillCard1`
    FOREIGN KEY (`idSkillCard` )
    REFERENCES `Esami ECDL`.`SkillCard` (`idSkillCard` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Esami ECDL`.`Sessione`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`Sessione` (
  `idSessione` INT NOT NULL AUTO_INCREMENT ,
  `data` DATETIME NULL ,
  `idSede` INT NOT NULL ,
  PRIMARY KEY (`idSessione`) ,
  INDEX `fk_Sessione_Sede1_idx` (`idSede` ASC) ,
  CONSTRAINT `fk_Sessione_Sede1`
    FOREIGN KEY (`idSede` )
    REFERENCES `Esami ECDL`.`Sede` (`idSede` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Esami ECDL`.`EsameSessione`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`EsameSessione` (
  `idEsami` INT NOT NULL ,
  `idSessione` INT NOT NULL ,
  `DurataEsame` VARCHAR(45) NULL ,
  PRIMARY KEY (`idEsami`, `idSessione`) ,
  INDEX `fk_Esami_has_Sessione_Sessione1_idx` (`idSessione` ASC) ,
  INDEX `fk_Esami_has_Sessione_Esami1_idx` (`idEsami` ASC) ,
  CONSTRAINT `fk_Esami_has_Sessione_Esami1`
    FOREIGN KEY (`idEsami` )
    REFERENCES `Esami ECDL`.`Esami` (`idEsami` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Esami_has_Sessione_Sessione1`
    FOREIGN KEY (`idSessione` )
    REFERENCES `Esami ECDL`.`Sessione` (`idSessione` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `Esami ECDL` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
