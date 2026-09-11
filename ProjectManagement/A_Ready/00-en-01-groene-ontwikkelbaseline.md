# EN-01: Herstel een groene ontwikkelbaseline

- **Type:** Technische enabler
- **Status:** Ready
- **Volgorde:** 1 van 13
- **Grootte:** S
- **Afhankelijkheden:** Geen

## Waarom

Een developer heeft snelle feedback nodig voordat er nieuw gedrag wordt toegevoegd.

## Acceptance criteria

- `npm run build` slaagt in `Frontend`.
- `npm run lint` slaagt in `Frontend`.
- `dotnet test` slaagt in de root van de repository.
- Ongebruikte of onvolledige layout-/routercode wordt correct aangesloten of verwijderd.
- De root-README legt uit hoe zowel de API als de frontend lokaal worden gestart.

## Huidige situatie

De API-testsuite slaagt met 4 tests, terwijl de frontend-build faalt omdat `Frontend/src/components/Layout.tsx` een niet-afgesloten `Outlet`-element bevat.
