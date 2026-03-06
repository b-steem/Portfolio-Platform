export interface Project {
  id: number;
  title: string;
  description: string;
  techStack: string[];
  gitHubUrl: string;
  liveUrl: string;
  imageUrl: string;
  featured: boolean;
  displayOrder: number;
}