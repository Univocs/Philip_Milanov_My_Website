import { Route, Routes } from "react-router-dom";
import LayOut from "./components/Layout";

function HomePage() {
  return <h1>Philip Milanov</h1>;
}

function AnimationPage() {
  return <h1>My Animations</h1>;
}

function RiggingPage() {
  return <h1>My Rigging</h1>;
}

function DevelopmentPage() {
  return <h1>.NET Development</h1>
}

function SportsPage() {
  return <h1>Sports Career</h1>
}

function ProjectsPage() {
  return <h1>My Projects</h1>;
}

function SkillsPage() {
  return <h1>My Skills</h1>;
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
    <Routes>
      <Route path="/" element={<LayOut />}>
        <Route index element={<HomePage />} />
        <Route path="/animation" element={<AnimationPage />} />
        <Route path="/rigging" element={<RiggingPage />} />
        <Route path="/development" element={<DevelopmentPage />} />
        <Route path="/sports" element={<SportsPage />} />
        <Route path="/projects" element={<ProjectsPage />} />
        <Route path="/skills" element={<SkillsPage />} />
        <Route path="/resume" element={<ResumePage />} />
        <Route path="/about" element={<AboutMePage />} />
        <Route path="/contact" element={<ContactPage />} />
      </Route>
    </Routes >
  );
}