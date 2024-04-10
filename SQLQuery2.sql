use ecommerce

CREATE TABLE comanda(
    id_comanda INT PRIMARY KEY,
    client INT,
    FOREIGN KEY (client) REFERENCES client(id_client)
);


CREATE TABLE produse_comanda(
    comanda INT,
    produs INT PRIMARY KEY,
	cantitate INT,
    FOREIGN KEY (produs) REFERENCES produs(id_produs),
	FOREIGN KEY (comanda) REFERENCES comanda(id_comanda)
);

