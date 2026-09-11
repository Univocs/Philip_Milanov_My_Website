import { Link, Route, Routes } from "react-router-dom";

function HomePage() {
  return <h1>Philip Milanov</h1>;
}

function AnimationPage() {
  return <h1>My Animations</h1>;
}

function RiggingPage() {
  return <h1>My Rigging</h1>;
}

function ProjectsPage() {
  return <h1>My Projects</h1>;
}

function ResumePage() {
  return <h1>My Resume</h1>;
}

function AboutMePage() {
  return <h1>About Me</h1>;
}

function ContactPage() {
  return <h1>Contact Me</h1>;
}

export default function App() {
  return (
    <>
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/animation" element={<AnimationPage />} />
        <Route path="/rigging" element={<RiggingPage />} />
        <Route path="/projects" element={<ProjectsPage />} />
        <Route path="/resume" element={<ResumePage />} />
        <Route path="/about" element={<AboutMePage />} />
        <Route path="/contact" element={<ContactPage />} />
      </Routes>
    </>
  );
}