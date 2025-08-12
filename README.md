           +----------------+
           |    Hayvan      |   <<abstract>>
           +----------------+
           | - turAdi       |
           | - agirlik      |
           | - yas          |
           +----------------+
           | + getDosage()  |
           | + getFeedSchedule() |
           +----------------+
                   ▲
   ┌───────────────┼─────────────────┐
   │               │                 │
+--------+    +-----------+     +---------+
|  At    |    |  Kaplan   |     |  Sican  |
+--------+    +-----------+     +---------+
|         |    |           |     |         |
+--------+    +-----------+     +---------+
| +getDosage()| +getDosage()|   | +getDosage()|
| +getFeedSchedule()| ...   |   | +getFeedSchedule()|
+------------------+---
![Hayvanat Bahçesi UML Diyagramı](uml.png)
