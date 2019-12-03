import { Photo } from './photo';

export interface User {
    id: number;
    username: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    country: string;
    interests?: string; // nullable variables or properties needs to go after the required fields.
    introduction?: string; // nullable variables or properties needs to go after the required fields.
    lookingFor?: string; // nullable variables or properties needs to go after the required fields.
    photos?: Photo[]; // nullable variables or properties needs to go after the required fields.
}
