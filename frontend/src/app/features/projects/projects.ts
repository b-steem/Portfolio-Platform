import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProjectsService } from '../../core/services/projects';
import { Project } from '../../shared/models/project.model';

@Component({
  selector: 'app-projects',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './projects.html',
  styleUrl: './projects.scss',
})
export class Projects implements OnInit {
  private readonly projectsService = inject(ProjectsService);

  projects: Project[] = [];
  isLoading = true;
  errorMessage = '';

  ngOnInit(): void {
    this.loadProjects();
  }

  private loadProjects(): void {
    this.projectsService.getFeaturedProjects().subscribe({
      next: (projects) => {
        this.projects = projects;
        this.isLoading = false;
      },
      error: () => {
        this.errorMessage = 'Unable to load projects right now.';
        this.isLoading = false;
      }
    });
  }

  reloadProjects(): void {
    this.isLoading = true;
    this.errorMessage = '';
    this.loadProjects();
  }
}
