﻿--create table FluxoCliente(
--IdFluxo int identity(1,1),
--IdFunc int,
--IdPlaca int,
--IdTempo int,
--IdPagamento int,
--constraint pk_IdFluxo primary key (IdFluxo),
--constraint fk_Fluxo_IdFunc foreign key (IdFunc) references Funcionario(IdFunc),
--constraint fk_Fluxo_IdPlaca foreign key (IdPlaca) references PlacaAuto(IdPlaca),
--constraint fk_Fluxo_IdTempo foreign key (IdTempo) references Tempo(IdTempo),
--constraint fk_Fluxo_IdPagamento foreign key (IdPagamento) references Pagamento(IdPagamento)
--)