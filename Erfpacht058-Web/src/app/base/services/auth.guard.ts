import { CanActivateFn } from '@angular/router';
import { jwtDecode } from 'jwt-decode';
import { HelperService } from './helper.service';

// Guard die controleert of de gebruiker nog een actieve sessie heeft adhv die token verkregen van de api

export const authGuard: CanActivateFn = (route, state) => {
  // Controleer of de token bestaat in de local storage
  const token = localStorage.getItem('token');
  const helper = new HelperService();

  if (token == null)
    return false; // token is niet aanwezig in browser storage
  
  // Controleer of de token nog geldig is en niet verlopen
  return helper.tokenValidator(token);
};