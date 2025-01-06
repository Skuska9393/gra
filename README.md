# ekologia dla najmłodszych (Unity Project)

## Opis projektu
ekologia dla najmłodszych to projekt stworzony w silniku Unity, który umożliwia użytkownikowi interaktywną manipulację obiektami 2D w przestrzeni. Projekt obejmuje podstawowe mechaniki, takie jak przeciąganie obiektów oraz ich obracanie za pomocą myszy. Główne funkcjonalności zostały zaimplementowane w języku C#.

## Funkcjonalności
1. **Przeciąganie obiektów**
   - Implementowane w skrypcie `DragAndDrop.cs`.
   - Umożliwia przeciąganie obiektów w przestrzeni 2D, przywracanie pozycji początkowej oraz intuicyjną obsługę myszy.

2. **Obracanie obiektów**
   - Implementowane w skrypcie `TouchRotate.cs`.
   - Pozwala na obracanie obiektów 3D w przestrzeni za pomocą ruchów myszy.

## Pliki w projekcie
- **Assets/** - Folder z zasobami projektu (modele, materiały, skrypty).
- **DragAndDrop.cs** - Skrypt obsługujący przeciąganie obiektów.
- **TouchRotate.cs** - Skrypt obsługujący obracanie obiektów.
- **Scenes/** - Sceny projektu.

## Jak uruchomić projekt
1. **Klonowanie repozytorium**:
   ```bash
   git clone https://github.com/Skuska9393/gra.git
   ```
2. **Otwórz projekt w Unity**:
   - Upewnij się, że masz zainstalowaną wersję Unity zgodną z tym projektem.
   - Otwórz Unity Hub, wybierz opcję "Open" i wskaż folder projektu.

3. **Uruchom scenę**:
   - W Unity, otwórz folder `Scenes` i uruchom główną scenę projektu.
   - Kliknij przycisk "Play", aby przetestować grę.

## Jak używać
1. **Przeciąganie obiektów**
   - Kliknij na obiekt i przeciągnij go w przestrzeni 2D.
   - Obiekt wróci do pozycji początkowej po wywołaniu metody `ResetPosition()` w skrypcie.

2. **Obracanie obiektów**
   - Kliknij na obiekt i przesuwaj myszą, aby go obracać wokół osi X i Y.
   - Ruch poziomy myszy obraca obiekt wokół osi Y, a pionowy wokół osi X.



## Autor
- **Monika Chojnacka**
- **Marta Furmańska**
- **Remigiusz Mróz**
- **Kamil Pęcherski**
