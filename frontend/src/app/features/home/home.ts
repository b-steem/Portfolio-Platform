import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';

import { Navbar } from '../../shared/components/navbar/navbar';
import { Footer } from '../../shared/components/footer/footer';
import { Projects } from "../projects/projects";
import { Contact } from "../contact/contact";

import { ProfileService } from '../../core/services/profile';
import { Profile } from '../../shared/models/profile.model';


@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
    CommonModule,
    Navbar, 
    Footer, 
    Projects, 
    Contact
  ],
  templateUrl: './home.html',
  styleUrl: './home.scss',
})
export class Home implements OnInit {
  private readonly profileService = inject(ProfileService);

  profile: Profile | null = null;
  isLoadingProfile = true;
  profileErrorMessage = '';
  
  ngOnInit(): void {
    this.loadProfile();
  }

  private loadProfile(): void {
    this.profileService.getProfile().subscribe({
      next: (profile) => {
        this.profile = profile;
        this.isLoadingProfile = false;
      },
      error: () => {
        this.profileErrorMessage = 'Unable to load profile right now.';
        this.isLoadingProfile = false;
      }
    });
  }
}
