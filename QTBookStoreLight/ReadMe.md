
# QTBookStoreLight

**Inhaltsverzeichnis**
1. [Einleitung](#einleitung)
2. [Datenmodell und Datenbank](#datenmodell-und-datenbank)
3. [Aufgaben](#aufgaben)
   1. [Backend-System](#backend-System)
      1. [Business-Logic](#business-logik)
      2. [Unit-Tests](#unit-tests)
      3. [AspMvc-Views](#aspmvc-views)

## Einleitung

Das Projekt ***QTBookStoreLight*** ist eine datenzentrierte Anwendung zur Verwaltung von OldTimers. 

Zu entwickeln ist das Backend-System mit der Datenbank-Anbindung, eine Web-Anwendung zur Verwaltung der Stammdaten der Projekte. Zusätzlich soll ein mobiler Client zum Ansehen und Bearbeiten einer Aufgabe erstellt werden.

## Datenmodell und Datenbank

Das Datenmodell für ***QTBookStoreLight*** hat folgenden Aufbau:

```txt

+-------+--------+ 
|                |
|     Book       + 
|                |
+-------+--------+

```

### Definition von ***Book***

| Name | Type | MaxLength | Nullable |Unique|Db-Field|Access|
|------|------|-----------|----------|------|--------|------|
| Id | int |---|---|---| Yes | R |
| RowVersion | byte[] |---| No |---| Yes | R |
| Author | String | 128 | No | No | Yes | RW |
| ISBNNumber | String | 10 | No | Yes | Yes | RW |
| Description | String | 2048 | No | No | Yes | RW |
| Price | double | --- | No | No | Yes | RW |
| Note | String | 1024 | Yes | No | Yes | RW |

## Aufgaben  

### Backend-System  

Erstellen Sie das Backend-System mit der Vorlage ***QuickTemplate*** und definieren die folgenden ***Komponenten***:

- Erstellen der ***Enumeration***
  - *keine*
- Erstellen der ***Entitäten***
  - *Vehicle*
- Definition des ***Datenbank-Kontext***
  - *DbSet&lt;Vehicle&gt;* definieren
  - partielle Methode ***GetDbSet<E>()*** implementieren
- Erstellen der ***Kontroller*** im *Logic* Projekt
  - ***BooksController***
- Erstellen der ***Datenbank*** mit den Kommandos in der ***Package Manager Console***
  - *add-migration InitDb*
  - *update-database*
- Implementierung der ***Business-Logic***
  - Überprüfen der Geschäftslogik mit ***UnitTests***
- Importieren von Daten (optional)

#### Business-Logik  

Das System muss einige Geschäftsregeln umsetzen. Diese Regeln werden im Backend implementiert und müssen mit UnitTests überprüft werden. 

> **HINWEIS:** Unter **Geschäftsregeln** (Business-Rules) versteht man **elementare technische Sachverhalte** im Zusammenhang mit Computerprogrammen. Mit *WENN* *DANN* Scenarien werden die einzelnen Regeln beschrieben.  

Für das ***QTVehicle*** sind folgende Regeln definiert:

| Rule | Subject | Type | Operation | Description | Note |
|------|---------|------|-----------|-------------|------|
|**A1**| Book |  |  |  |  |
|  |  |*WENN*|  | ein Buch erstellt oder bearbeitet wird, |  |
|  |  |*DANN*|  | muss ein Autor zugeordnet sein. |  |
|  |  |      | UND | die ISBNNumber muss gültig sein |  |
|  |  |      | UND | die ISBNNumber muss eindeutig sein. |  |

**Prüfung der ISBN-Nummer**

Die Prüfziffer (zehnte Ziffer) der ISBN-Nummer berechnet sich wie folgt:  
Man multipliziere die erste Ziffer mit eins, die zweite mit zwei, die dritte mit drei und so fort bis zur neunten Ziffer, die mit neun multipliziert wird.  
Man addiere die Produkte und teile die Summe ganzzahlig mit Rest durch 11. Der Divisionsrest ist die Prüfziffer.  
Falls der Rest 10 beträgt, ist die Prüfziffer ein "X".  
1. Beispiel: ISBN 3-499-13599-[?] (Fräulein Smillas Gespür für Schnee)
3·1 + 4·2 + 9·3 + 9·4 + 1·5 + 3·6 + 5·7 + 9·8 + 9·9 = 3 + 8 + 27 + 36 + 5 + 18 + 35 + 72 + 81 = 285
285:11 = 25 Rest 10 ⇒ Prüfziffer: X
2. Beispiel: ISBN 3-446-19313-[?] (Fermats letzter Satz)
3·1 + 4·2 + 4·3 + 6·4 + 1·5 + 9·6 + 3·7 + 1·8 + 3·9 = 3 + 8 + 12 + 24 + 5 + 54 + 21 + 8 + 27 = 162
162:11 = 14 Rest 8 ⇒ Prüfziffer: 8
3. Beispiel: ISBN 0-7475-5100-[?] (Harry Potter and the Order of the Phoenix)
0·1 + 7·2 + 4·3 + 7·4 + 5·5 + 5·6 + 1·7 + 0·8 + 0·9 = 14 + 12 + 28 + 25 + 30 + 7 = 116
116:11 = 10 Rest 6 ⇒ Prüfziffer: 6
4. Beispiel: ISBN 1-57231-422-[?] (Hardcore Visual Basic)
1·1 + 5·2 + 7·3 + 2·4 + 3·5 + 1·6 + 4·7 + 2·8 + 2·9 = 1 + 10 + 21 + 8 + 15 + 6 + 28 + 16 + 18 = 123
23:11 = 11 Rest 2 ⇒ Prüfziffer: 2  

Wenn die ISBN-Nummer nicht stimmt (ungültige Prüfziffer), dann wird eine Ausnahme geworfen.

#### Unit-Tests  

All diese Geschäftsregeln müssen mit **UnitTests** überprüft werden. Fügen Sie dazu zur Lösung (Solution) ein Projekt mit dem Namen ***'QTBookStoreLight.Logic.UnitTest'*** hinzu und implementieren Sie die Tests.
 
### AspMvc-Views  

Erstellen Sie für die folgenden Entitäten Ansichten im AspMvc-Projekt:

> Der Kontroller ***BooksContoller*** ist bereits erstellt.

- Book 
  - ListView - Übersicht der Authors
  - Create - Erstellen eines Authors
  - Edit - Bearbeiten eines Authors
  - Delete - Löschen eines Authors mit Rückfrage

> **HINWEIS:**  Ausnahmen und Fehler müssen dem Benutzer entsprechend angezeigt werden.

**Viel Spaß beim Umsetzen der Aufgabe!**
