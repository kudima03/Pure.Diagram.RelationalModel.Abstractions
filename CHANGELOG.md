# Changelog

All notable changes to Pure.Diagram.RelationalModel.Abstractions are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.2.0.0] — 2026-04-19

### Changed

- **`ISeriesRelationalModel`** renamed to **`IDiagramSeriesRelationalModel`**.

## [0.1.0-preview.1.0.0] — 2026-02-12

### Changed

- **`IDiagramRelationalModel`** no longer extends `IDiagram` from
  `Pure.Diagram.Model.Abstractions`; it is now a standalone interface with
  `Id`, `TypeId`, and new `Title` and `Description` (`IString`) properties.
- **`ISeriesRelationalModel`** no longer extends `ISeries`; it is now a
  standalone interface with `Id`, `DiagramId`, and new `Label` and `Source`
  (`IString`) properties.
- **`IDiagramTypeRelationalModel`** no longer extends `IDiagramType`; it is
  now a standalone interface with `Id` and a new `Name` (`IString`) property.
- The package dependency on `Pure.Diagram.Model.Abstractions` was removed in
  favor of `Pure.Primitives.Abstractions`.

## [0.1.0-preview.0.1.0] — 2026-02-11

### Added

- **`IDiagramTypeRelationalModel`** — extends `IDiagramType` with an `Id`
  (`IGuid`) property.
- **`ISeriesRelationalModel`** — extends `ISeries` with `Id` and `DiagramId`
  (`IGuid`) properties.
- **`IDiagramRelationalModel`** — extends `IDiagram` with `Id` and `TypeId`
  (`IGuid`) properties.
- Multi-targeting for `net7.0`, `net8.0`, `net9.0`, and `net10.0`.
