# Pure.Diagram.RelationalModel.Abstractions

Relational-model interfaces for diagram entities in the **Pure** ecosystem — immutable, composable contracts for diagrams, diagram types, and series.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.RelationalModel.Abstractions/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RelationalModel.Abstractions/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.RelationalModel.Abstractions/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RelationalModel.Abstractions/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.RelationalModel.Abstractions)](https://www.nuget.org/packages/Pure.Diagram.RelationalModel.Abstractions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.RelationalModel.Abstractions` defines minimal, read-only interfaces that represent the relational structure of diagram data. Each interface captures the identifiers and scalar properties that a diagram entity carries in a relational model. Properties are typed using primitives from [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions).

## Interfaces

| Interface | Namespace | Description |
|-----------|-----------|-------------|
| `IDiagramRelationalModel` | `Pure.Diagram.RelationalModel.Abstractions` | A diagram entity with identity, title, description, and type reference |
| `IDiagramTypeRelationalModel` | `Pure.Diagram.RelationalModel.Abstractions` | A diagram type with identity and name |
| `IDiagramSeriesRelationalModel` | `Pure.Diagram.RelationalModel.Abstractions` | A diagram series with identity, owning diagram reference, label, and source |

## Design Principles

- **Immutable** — all interfaces expose only `get` properties.
- **Primitive-typed** — identity expressed as `IGuid`, names and labels as `IString`.
- **AOT-compatible** — fully compatible with Native AOT compilation.

## Dependencies

- [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions) — `IGuid`, `IString` interfaces
