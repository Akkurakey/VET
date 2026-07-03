# VET: Virtual Exposure Therapy Prototype

A Unity-based AR/VR prototype for exposure-based therapy, built for the Meta Quest 3. The prototype presents spider and contamination exposure scenarios across both augmented and virtual reality, using the Quest 3 passthrough function to switch between modes and hand tracking for direct, controller-free interaction.

> **A note on terminology:** this project does not distinguish between AR and MR. Both are referred to as AR throughout, although the passthrough-based scenarios also fall within the scope of MR.

<br>

## Overview

The prototype comprises four scenarios integrated within a single Unity project: an AR spider scenario, a VR spider scenario, an AR contamination scenario, and a VR contamination scenario. Users are guided through the scenarios via in-headset instruction cards and can interact with the virtual models in each using their hands.

<br>

## Hardware and Engine

The prototype targets the **Meta Quest 3**.

Development was carried out in **Unity**.

- Unity 2022.3.22f1
- XR: OpenXR / XR Interaction Toolkit, with ARCore, ARKit, and Oculus loaders configured
- Interaction: Meta Quest 3 hand tracking

<br>

## Scenarios

▶️ **[Watch the demo video on YouTube](https://www.youtube.com/watch?v=r-H0cZzmMKs)**

[![VET demo video](https://img.youtube.com/vi/r-H0cZzmMKs/hqdefault.jpg)](https://www.youtube.com/watch?v=r-H0cZzmMKs)

### User interface
Instruction cards introduce and start the prototype, and a settings menu is opened by rotating the right hand. Through this menu the user can move between scenes, switch scenario, and switch between AR and VR modes.

### Spider scenario
Interactive virtual spiders with both static and moving states. While static, a spider shows small idle animations; touching or picking up a static spider triggers a moving state in which it crawls forward with leg animation.

- **AR:** the spider is superimposed onto a real-world surface (for example a table), which the user selects. Spiders can be generated anywhere on the identified surface.
- **VR:** a modelled bedroom environment (bed, desk, chair) with two static spiders pre-placed to model encountering spiders in an everyday setting.

### Contamination scenario
Scattered rubbish and a dirty rubbish bin, using various 3D rubbish models (decaying fruit, cans, plastic bottles). Rubbish can be picked up and moved, and the bin lid and inner bag can be manipulated.

- **AR:** the rubbish and bin are superimposed onto the real-world environment within a customisable generation area.
- **VR:** a surrounding modelled street corner with graffiti-covered walls and a dirty ground, presenting the rubbish and bin within a consistent environment.

<br>

## Getting Started

1. Clone the repository.
2. Open the project in Unity Hub (Unity 2022.3.22f1).
3. Import the third-party assets listed below from their sources.
4. Open a scene under `Assets/A-Scenes/` and press Play, or build to a Meta Quest 3.

<br>

## Third-Party Assets

The 3D assets below are **not redistributed** in this repository, for reasons of file size and licensing. Import them from the sources listed before running. Assets under CC BY 4.0 are credited to their original creators below.

| Asset (original name) | Used in | Author | Source | License |
|-----------------------|---------|--------|--------|---------|
| Animated Spider | Spider (AR/VR) | — | Unity Asset Store (appears removed, no longer available) | — |
| depression room | Spider (VR) | CrimsonJBK | [skfb.ly/oEErY](https://skfb.ly/oEErY) | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/) |
| Dirty Street Corner with Graffiti FREE | Contamination (VR) | roxyjungle | [skfb.ly/6nvtL](https://skfb.ly/6nvtL), [skfb.ly/6WMut](https://skfb.ly/6WMut) | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/) |
| rubbish | Contamination (AR/VR) | 3DWALKABOUT | [skfb.ly/oGz9S](https://skfb.ly/oGz9S) | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/) |
| Dirty Plastic Bottles Trash - 3 Piece Set | Contamination (AR/VR) | Sunbox Games | [skfb.ly/oODJT](https://skfb.ly/oODJT) | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/) |
| Cans - Dirty and Crumpled 3 Piece Set | Contamination (AR/VR) | Sunbox Games | [skfb.ly/oDVSF](https://skfb.ly/oDVSF) | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/) |
| Rotten Dirty Organic Waste | Contamination (AR/VR) | Sunbox Games | [skfb.ly/oFs8U](https://skfb.ly/oFs8U) | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/) |
| vomit | Contamination (AR/VR) | dante | [skfb.ly/6XpLS](https://skfb.ly/6XpLS) | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/) |
| Dirty Cardboard Box | Contamination (AR/VR) | marco.cossetti | Sketchfab | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/) |
| Garbage Bin | Contamination (AR/VR) | Rob Ortiz | [skfb.ly/onWL7](https://skfb.ly/onWL7) | [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/) |

> The Animated Spider asset appears to have been removed from the Unity Asset Store and may no longer be available. It is not included in this repository. To run the spider scenarios, substitute a comparable animated spider model with static and moving (crawling) states, and reassign it in the relevant scenes.

<br>

## Status

Research prototype. Built for a specific project and shared for transparency, rather than as production-ready software.


<br>
