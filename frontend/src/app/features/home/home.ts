import { Component } from '@angular/core';
import { Navbar } from '../../shared/components/navbar/navbar';
import { Footer } from '../../shared/components/footer/footer';
import { Projects } from "../projects/projects";
import { Contact } from "../contact/contact";

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [Navbar, Footer, Projects, Contact],
  templateUrl: './home.html',
  styleUrl: './home.scss',
})
export class Home {}
