<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X LitJson

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/releases)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · [QQ Group](https://qm.qq.com/q/urKenB9AU)

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## Project Overview

An improved LitJson library for Unity, repackaged from [XINCGer/LitJson4Unity](https://github.com/XINCGer/LitJson4Unity).

This library serves as a sub-module for [GameFrameX](https://github.com/AlianBlank/GameFrameX).

## Quick Start

Edit your Unity project's `Packages/manifest.json` and add the `scopedRegistries` section:

```json
{
  "scopedRegistries": [
    {
      "name": "GameFrameX",
      "url": "https://gameframex.upm.alianblank.uk",
      "scopes": [
        "com.gameframex"
      ]
    }
  ]
}
```

Then add this package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.xincger.litjson": "1.1.1"
  }
}
```

`scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

## Modifications

1. Added `link.xml` for stripping filter
2. Added `LitJsonCroppingHelper` anti-stripping script

## Features

Based on the [original LitJson library](https://github.com/LitJSON/litjson), with additional features not supported in the original:

- Support for float type
- Support for Unity built-in types (Vector2, Vector3, Rect, AnimationCurve, Bounds, Color, Color32, Quaternion, RectOffset, etc.)
- Support for JsonIgnore Attribute to skip serialization of certain fields
- Support for formatted JSON output
