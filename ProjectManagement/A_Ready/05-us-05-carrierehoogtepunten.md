# US-05: Carrièrehoogtepunten bekijken

- **Type:** User story
- **Status:** Ready
- **Volgorde:** 6 van 13
- **Grootte:** M
- **Afhankelijkheden:** US-03 als eerste walking skeleton

## Story

Als bezoeker wil ik Philips verschillende carrièreperiodes en verwezenlijkingen bekijken zodat ik begrijp hoe zijn ervaring zich heeft ontwikkeld.

## Acceptance criteria

- De API retourneert geseede carrière-items volgens `DisplayOrder`, met titel, beschrijving, jaartalbereik, belangrijkste vaardigheden en verwezenlijkingen.
- De frontend toont de items als een duidelijke tijdlijn of geordende lijst.
- Een ontbrekend eindjaar wordt weergegeven als huidig/lopend in plaats van leeg.
- Belangrijke vaardigheden worden consistent weergegeven en worden in de UI niet geparsed uit een ambigu, door komma's gescheiden weergavetekenreeks.
- Loading-, empty- en failure-states worden afgehandeld.
- Mapping en ordering worden automatisch getest.

## Refinementvraag

Beslis vóór de implementatie of `KeySkills` eenvoudige tekst blijft of een collectie wordt. Geef de voorkeur aan een collectie wanneer afzonderlijke skillchips of filtering nodig zijn.


