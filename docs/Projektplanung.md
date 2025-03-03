# SlotCarRennen - Projektplanung

## 1. Spielkomponenten

### 1.1 Benutzeroberfläche
- **Splashscreen**: Wird beim Start der Anwendung angezeigt
- **Hauptmenü**: Enthält die Optionen:
  - Start (beginnt das Spiel)
  - Quit (beendet die Anwendung)
- **Spiel**

### 1.2 Spielfeld
- Grid-basiertes Rennstrecken-Layout mit `Columns="10" Rows="15"`
- Jede Zelle enthält einen `TrackNode` der die Streckenelemente repräsentiert
- Jede Zelle wird als 3x3 Feld dargestellt, um Kurven und Geraden detailliert zu zeichnen

### 1.3 Spielinformationen
- **Für jeden Spieler**:
  - Geschwindigkeitsanzeige (km/h)
  - Punktestand (bereits gefahrene Runden)

## 2. Datenmodell

### 2.1 TrackNode-Klasse
```csharp
public class TrackNode
{
    public Orientation IngoingOrientation { get; set; }
    public Orientation OutgoingOrientation { get; set; }
}

public enum Orientation
{
    Top,
    Bottom,
    Left,
    Right,
}
```

### 2.2 Rennstrecke
- Die Strecke wird als Grid von `TrackNode`-Objekten gespeichert
- Jeder `TrackNode` definiert ein Streckenelement mit Ein- und Ausgangsrichtung
- Die Verbindung zwischen den Elementen wird durch passende Orientierungen sichergestellt

## 3. Datenspeicherung

### 3.1 XML-Format
- Die Strecke wird als XML-Datei auf dem Rechner des Anwenders gespeichert
- Vorteile: Bessere Validierungsmöglichkeiten und klare Struktur

### 3.2 XML-Schema
```xml
<TrackGrid>
  <Row>
    <TrackNode IngoingOrientation="Top" OutgoingOrientation="Bottom" />
    <TrackNode IngoingOrientation="Left" OutgoingOrientation="Right" />
  </Row>
  <Row>
    <TrackNode IngoingOrientation="Bottom" OutgoingOrientation="Top" />
    <TrackNode IngoingOrientation="Bottom" OutgoingOrientation="Right" />
  </Row>
</TrackGrid>
```

## 4. Spiellogik

### 4.1 Fahrzeugbewegung
- Steuerung der Slot Cars durch Spielereingaben
- Geschwindigkeitsberechnung
- Hinausfliegen des Fahrzeugs bei zu hoher Geschwindigkeit

### 4.2 Rundenzählung
- Zählen der komplettierten Runden für jeden Spieler
- Aktualisierung des Spieler-Scores bei Rundenvollendung

## 5. Grafikdarstellung

### 5.1 Streckenelemente
- Rendering der Streckenelemente basierend auf den TrackNode-Daten
- Verschiedene Grafikdarstellungen für:
  - Geraden (horizontal/vertikal)
  - Kurven (alle vier Richtungskombinationen)
  - Start/Ziel-Linie

### 5.2 Fahrzeuge
- Grafikdarstellung der Slot Cars
- Animation der Fahrzeuge während der Bewegung
- Anzeige der aktuellen Geschwindigkeit
- Bwegen der Fahrzeuge über 2 Tastatur buttons

## 6. Implementierungsplan

### 6.1 Phase 1: Grundstruktur
- Implementierung des Datenmodells (TrackNode, Orientation)
- XML-Speicher- und Ladefunktionalität

### 6.2 Phase 2: UI und Grafik
- Implementierung des Splashscreens und Hauptmenüs
- Rendering der Strecke aus XML-Daten
- Designelemente für Streckenabschnitte

### 6.3 Phase 3: Spiellogik
- Implementierung der Fahrzeugbewegung
- Rundenzählung und Scoreanzeige
- Geschwindigkeitsberechnung

### 6.4 Phase 4: Finalisierung
- Spielersteuerung
- Spielstatistiken
- Fehlerbehebung und Optimierung