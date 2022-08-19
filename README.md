<a name="readme-top"></a>
<h3 align="center">FPS Display For Unity</h3>

<!-- PROJECT LOGO -->
<div align="center">
<a href="https://github.com/hamdanbasri/AutoRotateControl/blob/main/AutoRotateControl.cs">
<img src="images/FPSDisplayLogo.png" alt="Logo">
</a>
<p align="center">
A simple code to display the FPS in your game.
</p>
</div>
<hr>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#about">About</a></li>
    <li><a href="#functions">Functions</a></li>
    <li><a href="#getting-started">Getting Started</a></li>
    <li><a href="#example">Example</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->
## About

[![Made with Unity](https://img.shields.io/badge/Made%20with-Unity-57b9d3.svg?style=for-the-badge&logo=unity)](https://unity3d.com)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Beginner](https://img.shields.io/badge/-Plug%20%26%20Play-yellow?style=for-the-badge)
</br>
Too tired of creating a simple rotating animation for a single gameobject?
</br>
Realizing that you need to create the same rotating animation for another gameobject?
</br>
Me too, that is why I created this simple to use [Auto Rotate Control](https://github.com/hamdanbasri/AutoRotateControl/blob/main/AutoRotateControl.cs) script.

<!-- FUNCTIONS -->
## Functions

* Instant rotation of GameObjects.
* Add as many objects that you want to rotate together.
* Assign keys to rotate and reset the rotation.
* Adjust the speed of the rotation.    

<!-- GETTING STARTED -->
## Getting Started

* Open Unity and add a <strong>Cube</strong> to the scene.
* Create an empty GameObject and rename it to <strong>AutoRotateControl</strong>.
* Attach the [AutoRotateControl.cs](https://github.com/hamdanbasri/AutoRotateControl/blob/main/AutoRotateControl.cs) script to the <strong>AutoRotateControl</strong>.
* Add the <strong>Cube</strong> or as many GameObjects that you want to rotate together in the same script by adding them to the <strong>Object To Rotate</strong> list.
* If you want to rotate the object/objects on key press, simply check the <strong>Key Press Enable</strong> and select the keys you wish to use.
* Adjust the speed by moving the <strong>Slider</strong>.
* Add <strong>Notes</strong> on top to keep track of the objects that you AutoRotate.
* Press <strong>Play</strong> in your editor and all the objects you had assigned will now rotate according to your settings.

<!-- USAGE EXAMPLES -->
## Example

<div align="center">
<img src="images/FPSDisplaySample.jpg" alt="Sample">
<p align="center">
Simply add the script to any GameObject and set the properties.
</p>
</br>
        <table>
        <tr>
            <td>Variable</td>
            <td>Annotation</td>
            </td>
        <tr>
            <td>Notes</td>
            <td>Add Notes</td>
        </tr>
        <tr>
            <td>Start Rotate Key</td>
            <td>Set the key to press to start the rotation</td>
        </tr>
        <tr>
            <td>Reset Rotation Key</td>
            <td>Set the key to press to reset the rotation</td>
        </tr>
        <tr>
            <td>Key Press Enable</td>
            <td>If enable, rotation will only start on the key pressed assigned to Start Rotate Key</td>
        </tr>
        <tr>
            <td>Positive X</td>
            <td>The GameObject/GameObjects will rotate in the Vector3.right direction</td>
        </tr>
        <tr>
            <td>Negative X</td>
            <td>The GameObject/GameObjects will rotate in the Vector3.left direction</td>
        </tr>
        <tr>
            <td>Positive Y</td>
            <td>The GameObject/GameObjects will rotate in the Vector3.up direction</td>
        </tr>
        <tr>
            <td>Negative Y</td>
            <td>The GameObject/GameObjects will rotate in the Vector3.down direction</td>
        </tr>
        <tr>
            <td>Positive Z</td>
            <td>The GameObject/GameObjects will rotate in the Vector3.back direction</td>
        </tr>
        <tr>
            <td>Negative Z</td>
            <td>The GameObject/GameObjects will rotate in the Vector3.forward direction</td>
        </tr>
        <tr>
            <td>Speed</td>
            <td>Adjust the speed of the rotation</td>
        </tr>
        <tr>
            <td>Object To Rotate</td>
            <td>Arrays of object to be rotated</td>
        </tr>
        </table>
</div>

<!-- CONTACT -->
## Contact

[![Twitter](https://img.shields.io/badge/Twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/its_danisauraus)
[![LinkedIn][linkedin-shield]][linkedin-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/hamdanbasri

