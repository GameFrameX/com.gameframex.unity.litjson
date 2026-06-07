<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X LitJson

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#quick-start) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 프로젝트 개요

Unity용 개선된 LitJson 라이브러리로, [XINCGer/LitJson4Unity](https://github.com/XINCGer/LitJson4Unity)를 기반으로 재패키지되었습니다.

이 라이브러리는 [GameFrameX](https://github.com/AlianBlank/GameFrameX)의 서브 모듈로 사용됩니다.

## 빠른 시작

### 설치

다음 방법 중 하나를 선택하세요:

1. Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:
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
     ],
     "dependencies": {
       "com.gameframex.unity.xincger.litjson": "1.1.2"
     }
   }
   ```

   `scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

2. `manifest.json`의 `dependencies`에 직접 추가:
   ```json
   {
      "com.gameframex.unity.xincger.litjson": "https://github.com/gameframex/com.gameframex.unity.xincger.litjson.git"
   }
   ```
3. Unity의 **Package Manager**에서 **Git URL**을 사용하여 추가: `https://github.com/gameframex/com.gameframex.unity.xincger.litjson.git`
4. 리포지토리를 Unity 프로젝트의 `Packages` 디렉토리에 클론하세요. 자동으로 로드됩니다.

Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:

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

그런 다음 `dependencies`에 이 패키지를 추가하세요:

```json
{
  "dependencies": {
    "com.gameframex.unity.xincger.litjson": "1.1.1"
  }
}
```

`scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

## 수정 사항

1. `link.xml` 스트리핑 필터 추가
2. `LitJsonCroppingHelper` 안티 스트리핑 스크립트 추가

## 특징

[원본 LitJson 라이브러리](https://github.com/LitJSON/litjson)를 기반으로, 원본에서 지원하지 않는 다음 기능을 추가했습니다:

- float 타입 지원
- Unity 내장 타입 지원 (Vector2, Vector3, Rect, AnimationCurve, Bounds, Color, Color32, Quaternion, RectOffset 등)
- JsonIgnore Attribute를 통한 특정 필드 직렬화 건너뛰기
- JSON 출력 포맷팅 지원
