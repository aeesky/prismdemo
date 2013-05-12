Aplikacji PrismDemo s�u�y do testowania biblioteki Prism oraz r�nych koncepcji wdra�anych p�niej do aplikacji Pharmacy.

W pliku tym znajduje si� og�lny opis budowy aplikacji. W komentarzach w kodzie znajduj� si� szczeg�y implementacyjne poszczeg�lnych element�w projektu.

W katalogu Libs znajduj� si� wszystkie dodatkowe biblioteki potrzebne do dzia�ania aplikacji.

Katalog src to katalog, w kt�rym znajduje si� kod aplikacji.

Aplikacji jest zbudowana z kilku projekt�w, gdzie poszczeg�lne projekty maj� nast�puj�ce znaczenie:

*Prism.Shell - jest to g��wny projekt aplikacji, w kt�rym znajduj� si� dwa podstawowe elementy: 
	Shell, czyli okno g��wne aplikacji, w kt�rym okre�lone s� regionu wykorzystywane przez modu�y do wy�wietlania swoich widok�w. 
	Bootstrapper - klasa odpowiedzialna za proces uruchamiania aplikacji oraz inicjacj� modu��w aplikacji.

*Prism.Infrastucture - w projekcie tym znajduj� si� elementy infrastrukturalne ca�ej aplikacji, takie jak og�lne interfejsy, klasy bazowego, wsp�lne wiadomo�ci itp. Projekty modu��w bazuj� na tym projekcie.

*Prism.Entities - w projekcie tym znajduje si� klasy encyjne wykorzystywane w aplikacji.

*Prism.Module1 - przyk�adowy modu� aplikacji, kt�ry zawiera widoku, viewmodele itp.

*Prism.Module1Test - projekt test�w dla modu�u Prism.Module1.

Analiz� przyk�adu najlepiej zacz�� od projektu Prism.Shell, nast�pnie Prism.Module1 oraz Prism.Module1.Tests (przy okazji analizuj� kod pozosta�ych modu��w).