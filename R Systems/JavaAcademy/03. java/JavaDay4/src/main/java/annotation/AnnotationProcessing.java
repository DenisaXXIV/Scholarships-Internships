package annotation;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.lang.annotation.Annotation;
import java.lang.reflect.Method;

public class AnnotationProcessing {
    public static void log(Object o, String methodName ) {
        for (Method m : o.getClass().getMethods()) {
            if (m.getName().equals(methodName)) {
                for (Annotation a : m.getAnnotations()) {
                    if (a instanceof CheckIfNegative) {
                        CheckIfNegative checkIfNegative = (CheckIfNegative) a;
                        ;

                        Logger logger = LoggerFactory.getLogger(AnnotationProcessing.class);
                        logger.error("!!! The value is negative !!!");
                    }
                }
                break;

            }

        }

    }
}
