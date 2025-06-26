# 🕶️ GWW IPB VIRTUAL TOUR

A virtual reality experience that allows users to explore the Gedung Widya Wacana (GWW) building through immersive VR interaction. This project leverages Unity’s XR Toolkit to simulate real-world teleportation and spatial navigation inside the GWW environment.

---

## ✨ Features

- 🌍 360° panoramic virtual environment of GWW
- 🧭 Teleportation to 6 key areas
- 🔍 Gaze-based interaction system
- 🛠️ Modular teleportation anchors
- 🎯 Optimized for mouse/keyboard simulation in editor (for development without VR hardware)
- 🧩 playable quiz with player score (coming soon)

---

## 🛠️ Installation

### Prerequisites
- Unity Hub + Unity Editor version **2022.3 LTS** (URP Template)
- Git + Git LFS installed
- Clone the repository:

```bash
git lfs install
git clone https://github.com/your-username/GWW-Virtual-Tour.git
```
---

🏁 Getting Started
1. Open the project in Unity Hub.
2. Open the scene: Assets/Scenes/SampleScene.unity.
3. Enter Play mode.
4. Use mouse and keyboard to navigate:
  - press left-key mouse to change gaze
  - WASD to move

---

🛠️ Development Methodology
This project uses the Incremental Development method:
1. Plan: Identify core features (teleport, VR camera, UI)
2. Build: Implement one feature at a time (e.g., adding teleport anchors)
3. Test & Adjust: Minor improvements made continuously based on feedback
4. Repeat: Iterate to add new features while keeping stability

---

📊 Discussion of Results

- Successfully implemented 6 teleportation anchors across GWW using Teleportation Anchor components with gaze interaction or mouse input for testing.
- Improved Git hygiene by updating .gitignore to exclude unnecessary Logs/, Temp/, and UnityLockfile to avoid permission errors or file clutter.
- .gitattributes added to enforce consistent line endings (text=auto) across different systems, preventing warnings about LF/CRLF conversions during commits.
- Based on Unity’s official XR Toolkit documentation and best practices in version control.

