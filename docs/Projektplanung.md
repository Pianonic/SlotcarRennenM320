# SlotCarRennen - Projektplanung

## 1. Spielkomponenten

### 1.1 Benutzeroberfläche ✅
- **Spiel**: Zeigt die Rennstrecke an

### 1.2 Spielfeld ✅
- Grid-basiertes Rennstrecken-Layout
- Jede Zelle enthält einen `TrackNode` der die Streckenelemente repräsentiert
- Jede Zelle wird als 3x3 Grid dargestellt, um Kurven und Geraden detailliert zu zeichnen
- Gelbe Rechtecke zeigen die Streckenführung an
- Rote Umrandung zeigt die Grid-Zellen

### 1.3 Geplante Spielinformationen
- **Für jeden Spieler**:
  - Geschwindigkeitsanzeige (km/h)
  - Punktestand (bereits gefahrene Runden)

## 2. Datenmodell

### 2.1 TrackNode-Klasse ✅
```csharp
public class TrackNode
{
    public Orientation IngoingOrientation { get; set; }
    public Orientation OutgoingOrientation { get; set; }
    public bool IsActive => IngoingOrientation != Orientation.None || OutgoingOrientation != Orientation.None;
}

public enum Orientation
{
    None,
    Top,
    Bottom,
    Left,
    Right,
}
```

### 2.2 Rennstrecke ✅
- Die Strecke wird als ObservableCollection von ObservableCollection<TrackNode> gespeichert
- Jeder `TrackNode` definiert ein Streckenelement mit Ein- und Ausgangsrichtung
- Die Verbindung zwischen den Elementen wird durch passende Orientierungen sichergestellt
- Leere Streckenabschnitte haben die Orientation "None"

## 3. Datenspeicherung

### 3.1 XML-Format ✅
- Die Strecke wird als XML-Datei gespeichert
- Vorteile: Bessere Validierungsmöglichkeiten und klare Struktur
- Implementiert in `Assets/Tracks/default.xml`

### 3.2 XML-Schema ✅
```xml
<Track>
  <Rows>
    <Row>
      <Node IngoingOrientation="Top" OutgoingOrientation="Bottom" />
      <Node IngoingOrientation="Left" OutgoingOrientation="Right" />
    </Row>
  </Rows>
</Track>
```

## 4. Geplante Spiellogik

### 4.1 Fahrzeugbewegung
- Steuerung der Slot Cars durch Spielereingaben
- Geschwindigkeitsberechnung
- Hinausfliegen des Fahrzeugs bei zu hoher Geschwindigkeit

### 4.2 Rundenzählung
- Zählen der komplettierten Runden für jeden Spieler
- Aktualisierung des Spieler-Scores bei Rundenvollendung

## 5. Grafikdarstellung

### 5.1 Streckenelemente ✅
- Rendering der Streckenelemente basierend auf den TrackNode-Daten
- Implementierte Grafikdarstellungen für:
  - Geraden (horizontal/vertikal)
  - Kurven (alle vier Richtungskombinationen)
  - Leere Felder (keine Anzeige)

### 5.2 Geplante Fahrzeugdarstellung
- Grafikdarstellung der Slot Cars
- Animation der Fahrzeuge während der Bewegung
- Anzeige der aktuellen Geschwindigkeit
- Bewegen der Fahrzeuge über 2 Tastatur buttons

## 6. Implementierungsstand

### 6.1 Phase 1: Grundstruktur ✅
- Implementierung des Datenmodells (TrackNode, Orientation)
- XML-Speicher- und Ladefunktionalität

### 6.2 Phase 2: UI und Grafik ✅
- Rendering der Strecke aus XML-Daten
- Designelemente für Streckenabschnitte

### 6.3 Phase 3: Ausstehende Spiellogik
- Implementierung der Fahrzeugbewegung
- Rundenzählung und Scoreanzeige
- Geschwindigkeitsberechnung

### 6.4 Phase 4: Ausstehende Finalisierung
- Spielersteuerung
- Spielstatistiken
- Fehlerbehebung und Optimierung