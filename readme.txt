Po pobraniu projektu należy zmienić connection string by łączył się z bazą lokalną.

Po zmianie connection string należy wykonać migracje update-database initial
Po tym można uruchomić stronę.

Niestety sporo rzeczy w projekcie nie działa i nie jest on taki jak planowałem 
Są 3 tabele łącznie z 2 relacjami.

Poprawnie w pełni działa tylko Category, działa wyświetlanie listy, dodawanie elementów, 
edycja i usówanie oraz validacja po stronie użytkowanika jak i serwera.

Product i Producent tworzą się w bazie z relacją tylko pojawił się problem z tworzenie i zapisywaniem tych elementów.