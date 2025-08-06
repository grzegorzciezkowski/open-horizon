# Open Horizon
Open Horizon is a space-themed MMO set in the Lambda sector, where players arrive through the one-way Genesis Gate as pioneers of a new frontier. The game features a non-linear single-player storyline, three human factions, powerful NPC enemies, and full support for open source development.

# Mono repo approach
The use of a monorepo in the Open Horizon project was driven by the need for better code consistency, simplified dependency management, and to support faster, community-driven open source development. A unified repository allows both the core team and contributors to work on different components of the game in one place, with shared versioning and CI/CD pipelines.

The repository is logically divided into three main parts:

## 🛠️ 1. Server (MMO component)
Contains the backend code responsible for:
- synchronizing the game world between players,
- handling server-side logic for factions, trade, combat, and exploration,
- managing player accounts, instances, and cross-sector travel.

## 🎮 2. Client (single-player and MMO frontend)
Includes:
- the game engine and 3D interface,
- the full single-player storyline and campaign,
- real-time integration with the MMO backend,

## 📚 3. Docs (technical and project documentation)
Provides:
- detailed API references for both client and server,
- data schemas (e.g., ships, factions, resources),
- contribution guidelines for the open source community,
- overview of the game’s storyline,
