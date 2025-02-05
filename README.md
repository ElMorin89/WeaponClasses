# Weapon Evolution Mod for ROUNDS

This ROUNDS mod introduces new classes focused on weapon modification and evolution. As players progress through the game, they can evolve their weapons to become more powerful and efficient.

## Composition

- **[MWC] Morino Weapons Cards** - Category containing Weapon Classes (main focus of the mod)
- **[MGC] Morino Global Cards** - Category containing generic cards that add "juice" for testing the mod standalone
- **[MTC] Morino Test Cards** - Not intended for gameplay (toggle off this category). Used for testing game mechanics

## Available Weapons

Currently, there are 3 different weapon types, each with unique characteristics:

- **Pistol**: Precise and reliable
- **Shotgun**: Powerful close-range weapon
- **SMG**: Rapid-fire automatic weapon

## Base Weapon Stats

| STATS                    | PISTOL   | SHOTGUN  | SMG      |
|--------------------------|----------|----------|----------|
| damage                   | 0.70     | 0.50     | 0.30     |
| attackSpeed              | 0.40     | 0.80     | 0.25     |
| reloadTime               | 1.00     | 2.00     | 1.60     |
| ammo                     | 4        | 4        | 6        |
| numberOfProjectiles      | 1        | 4        | 1        |
| spread                   | 0.00     | 0.20     | 0.10     |
| projectileSpeed          | 1.00     | 2.00     | 1.50     |
| projectielSimulatonSpeed | 1.00     | 1.00     | 2.00     |
| drag                     | 0        | 0        | 2        |
| destroyBulletAfter       | 0        | 0.15     | 0        |
| autoFire                 | false    | false    | true     |

## Level 2 Weapon Stats

| STATS                    | PISTOL   | SHOTGUN  | SMG      |
|--------------------------|----------|----------|----------|
| damage                   | 1.00     | 0.70     |          |
| attackSpeed              | 0.27     | 0.70     |          |
| reloadTime               | 0.90     | 1.75     |          |
| ammo                     | 8        | 8        |          |
| numberOfProjectiles      | 1        | 4        |          |
| spread                   | 0.00     | 0.15     |          |
| projectileSpeed          | 1.75     | 2.00     |          |
| projectielSimulatonSpeed | 1.00     | 1.00     |          |
| drag                     | 0        | 0        |          |
| destroyBulletAfter       | 0        | 0.20     |          |
| autoFire                 | false    | false    |          |

## Roadmap

As the mod is in early development, there are several planned features:

### Weapon Development
- [ ] Balance Level 1 to 2 of the first 3 weapons
- [ ] Add Level 2 upgrades
- [ ] Add Level 3 weapons
- [ ] Add Level 3 Upgrades
- [ ] Add Assault Rifle (Medium range with burst of bullets)
- [ ] Add Sniper Rifle (Long range with high damage, but slow)

### Character Development
- [ ] First draft of character class system
- [ ] First draft of archetype system

### Class System Vision
The goal is to implement a mixed class system where progression unlocks new archetypes and legendary weapons. For example:
- Level 2 pistol + Level 1 Character A → Legendary Weapon X
- Level 3 pistol + Level 2 Character B → Legendary Weapon Y

## Changelog

### [v0.1.0] - 2025-02-05
- Initial release