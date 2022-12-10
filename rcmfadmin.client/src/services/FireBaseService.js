import { initializeApp } from "firebase/app";
import {
  collection,
  doc,
  getFirestore,
  limit,
  orderBy,
  query,
  addDoc,
  Firestore,
} from "firebase/firestore";

export const firebaseApp = initializeApp(firebaseConfig);
export const db = getFirestore(firebaseApp);
import { getDownloadURL, getStorage, listAll, ref } from "firebase/storage";
import { AppState } from "../AppState.js";
import { firebaseConfig } from "../env.js";
import { logger } from "../utils/Logger.js";
class FiresService {
  async getFaceBookPictures() {
    const storage = getStorage();

    const imagesRef = ref(storage, "facebookPictures");
    const test = await listAll(imagesRef);
    logger.log(test);
    for await (const x of test.items) {
      let test = await getDownloadURL(x);
      AppState.photos.push(test);
    }
    return test;
  }
  async getUrls() {
    const imagesRef = collection(db,"images")
    // imagesRef
  }
}
export const firesService = new FiresService();
