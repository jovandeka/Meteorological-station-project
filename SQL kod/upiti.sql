USE `IS_Meteoroloske_stanice` ;

SELECT * FROM WMO_standard;
/prikazuje standarde svetske meteorološke organizacije/

SELECT * FROM stanica WHERE naz_stan="RHMZ Srbije";
/prikazuje sve podatke o stanicama čiji je naziv RHMZ Srbije/

SELECT * FROM glavni_prog g, merenje m WHERE m.ID_merenja=g.ID_merenja;
/prikazuje sve rezultate merenja glavnih programa/

SELECT o.ime, o.prezime, o.dat_zap, g.naziv FROM osmatrač o, grad g WHERE o.ptt=g.ptt;
/prikazuje ime, prezime, datum zaposlenja svih radnika i gradove odakle dolaze/

SELECT ime, max(nadm_vis) FROM osmatrač o, stanica s WHERE o.ID_stanice=s.ID_stanice;
/prikazuje ime radnika koji radi u stanici sa najvišom nadmorskom visinom i njenu visinu/
