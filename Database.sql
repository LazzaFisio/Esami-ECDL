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
  `idCittà` VARCHAR(45) NOT NULL ,
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
  `Città_idCittà` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`codice`) ,
  INDEX `fk_Esaminandi_Città1_idx` (`Città_idCittà` ASC) ,
  CONSTRAINT `fk_Esaminandi_Città1`
    FOREIGN KEY (`Città_idCittà` )
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
  `Città_idCittà` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`idSede`) ,
  INDEX `fk_Sede_Città1_idx` (`Città_idCittà` ASC) ,
  CONSTRAINT `fk_Sede_Città1`
    FOREIGN KEY (`Città_idCittà` )
    REFERENCES `Esami ECDL`.`Città` (`idCittà` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Esami ECDL`.`Risultato`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`Risultato` (
  `esaminandiCodice` INT NOT NULL ,
  `idEsami` INT NOT NULL ,
  `esito` VARCHAR(45) NULL ,
  `percentuale` VARCHAR(45) NULL ,
  PRIMARY KEY (`esaminandiCodice`, `idEsami`) ,
  INDEX `fk_Esaminandi_has_Esami_Esami1_idx` (`idEsami` ASC) ,
  INDEX `fk_Esaminandi_has_Esami_Esaminandi_idx` (`esaminandiCodice` ASC) ,
  CONSTRAINT `fk_Esaminandi_has_Esami_Esaminandi`
    FOREIGN KEY (`esaminandiCodice` )
    REFERENCES `Esami ECDL`.`Esaminandi` (`codice` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Esaminandi_has_Esami_Esami1`
    FOREIGN KEY (`idEsami` )
    REFERENCES `Esami ECDL`.`Esami` (`idEsami` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Esami ECDL`.`Sessione`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`Sessione` (
  `idSessione` INT NOT NULL AUTO_INCREMENT ,
  `data` DATETIME NULL ,
  `Sede_idSede` INT NOT NULL ,
  PRIMARY KEY (`idSessione`) ,
  INDEX `fk_Sessione_Sede1_idx` (`Sede_idSede` ASC) ,
  CONSTRAINT `fk_Sessione_Sede1`
    FOREIGN KEY (`Sede_idSede` )
    REFERENCES `Esami ECDL`.`Sede` (`idSede` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Esami ECDL`.`EsameSessione`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Esami ECDL`.`EsameSessione` (
  `Esami_idEsami` INT NOT NULL ,
  `Sessione_idSessione` INT NOT NULL ,
  PRIMARY KEY (`Esami_idEsami`, `Sessione_idSessione`) ,
  INDEX `fk_Esami_has_Sessione_Sessione1_idx` (`Sessione_idSessione` ASC) ,
  INDEX `fk_Esami_has_Sessione_Esami1_idx` (`Esami_idEsami` ASC) ,
  CONSTRAINT `fk_Esami_has_Sessione_Esami1`
    FOREIGN KEY (`Esami_idEsami` )
    REFERENCES `Esami ECDL`.`Esami` (`idEsami` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Esami_has_Sessione_Sessione1`
    FOREIGN KEY (`Sessione_idSessione` )
    REFERENCES `Esami ECDL`.`Sessione` (`idSessione` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `Esami ECDL` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
